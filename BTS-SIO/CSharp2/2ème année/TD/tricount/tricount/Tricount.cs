using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace tricount
{
    class Tricount
    {
        private string name;
        private List<Participant> mesParticipants;
        private Participant createur;
        private List<Depense> listeDepenses;

        public Tricount(string name, Participant createur)
        {
            this.name = name;
            this.createur = createur;
            mesParticipants = new List<Participant>();
            mesParticipants.Add(createur);
            listeDepenses = new List<Depense>();
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetNomCreateur()
        {
            return this.createur.GetName();
        }

        public Participant GetCreateur()
        {
            return this.createur;
        }

        public List<Depense> GetListeDepenses()
        {
            return this.listeDepenses;
        }

        public List<Participant> GetListeParticipants()
        {
            return this.mesParticipants;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetCreateur(Participant createur)
        {
            this.createur = createur;
        }

        public void SetListeParticipants(List<Participant> mesParticipants)
        {
            this.mesParticipants = mesParticipants;
        }

        public void SetListeDepenses(List<Depense> listeDepenses)
        {
            this.listeDepenses = listeDepenses;
        }

        public void AfficherParticipants(ref ListBox listeFormParticipants)
        {
            int j = 0;
            listeFormParticipants.Controls.Clear();

            foreach (Participant p in mesParticipants)
            {
                CheckBox c = new CheckBox();
                c.AutoSize = true;
                c.Location = new System.Drawing.Point(10, j);
                c.Name = "cb" + p.GetName();
                c.Size = new System.Drawing.Size(80, 17);
                c.TabIndex = 10;
                c.Text = p.GetName();
                c.Tag = p;
                c.UseVisualStyleBackColor = true;
                listeFormParticipants.Items.Add(c);
                listeFormParticipants.Controls.Add(c);
                j = j + 20;
            }
        }

        public void AfficherPayeur(ref ListBox listeFormParticipants)
        {
            int i = 0;
            int j = 0;
            listeFormParticipants.Controls.Clear();

            foreach (Participant p in mesParticipants)
            {
                RadioButton rb = new RadioButton();
                if(i == 0)
                    rb.Checked = true;
                rb.TabIndex = i;
                rb.AutoSize = true;
                rb.Location = new System.Drawing.Point(10, j);
                rb.Name = "rb" + p.GetName();
                rb.Size = new System.Drawing.Size(80, 17);
                rb.TabIndex = 10;
                rb.Text = p.GetName();
                rb.Tag = p;
                rb.UseVisualStyleBackColor = true;
                listeFormParticipants.Items.Add(rb);
                listeFormParticipants.Controls.Add(rb);

                j = j + 20;
                i++;
            }
        }

        public void AjouterParticipants(Participant p)
        {
            mesParticipants.Add(p);
        }

        public void SupprimerParticipant(Participant p)
        {
            if (mesParticipants.Count <= 0)
                MessageBox.Show("On ne peut pas supprimer le seul participant restant de ce Tricount.");
            else 
            {
                if (p == createur)
                    MessageBox.Show("On ne peut pas supprimer le créateur de ce Tricount.");
                else
                {
                    if (p.GetBalance() != 0)
                        MessageBox.Show("Le participant a participé à une dépense");
                    else
                    {
                        mesParticipants.Remove(p);
                        for (int i = 0; i < listeDepenses.Count; i++)
                        {
                            if (p == listeDepenses[i].GetLePayeur())
                                DonneesPubliques.GetUneDepense().SetLePayeur(DonneesPubliques.GetMonTricount().GetCreateur());
                        }
                    }
                }
            }
        }


        public void EffectueLesRemboursements(List<Participant> listeReceveur, List<Participant> listeDonneur, ref ListBox lbRemboursement)
        {
            listeReceveur.Sort();
            listeDonneur.Sort();
            float montant;
            Remboursement r;
            float cpBalancePayeur;
            float cpBalanceRembourse;

            for(int i = 0; i < listeReceveur.Count; i++)
            {
                cpBalancePayeur = Math.Abs(listeReceveur[i].GetBalance());

                for (int j = 0; j < listeDonneur.Count; j++)
                {
                    cpBalanceRembourse = Math.Abs(listeDonneur[j].GetBalance());

                    if (cpBalancePayeur > 0 && cpBalanceRembourse <= cpBalancePayeur)
                    {
                        montant = cpBalanceRembourse;
                        r = new Remboursement(listeDonneur[j], listeReceveur[i], montant);
                        lbRemboursement.Items.Add(r.ToString());
                        cpBalancePayeur -= cpBalanceRembourse;
                    }
                }

            }

        }


    }
}
