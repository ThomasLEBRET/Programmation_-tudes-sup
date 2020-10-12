using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tricount
{
    class Depense
    {
        private string titre;
        private float montant;
        private DateTime date;
        private List<Participant> concernes;
        private Participant lePayeur;

        
        public Depense(string titre, float unMontant, List<Participant> concerne, Participant lePayeur)
        {
            this.titre = titre;
            this.montant = unMontant;
            this.date = DateTime.Today;
            this.concernes = concerne;
            this.lePayeur = lePayeur;
        }

        public string GetTitre()
        {
            return this.titre;
        }

        public float GetMontant()
        {
            return this.montant;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public List<Participant> GetConcerne()
        {
            return this.concernes;
        }

        public Participant GetLePayeur()
        {
            return this.lePayeur;
        }

        public void SetTitre(string titre)
        {
            this.titre = titre;
        }

        public void SetMontant(float montant)
        {
            this.montant = montant;
        }

        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public void SetLePayeur(Participant lePayeur)
        {
            this.lePayeur = lePayeur;
        }

        public void GetConcerne(List<Participant> concerne)
        {
            this.concernes = concerne;
        }

        public void GetLePayeur(Participant lePayeur)
        {
            this.lePayeur = lePayeur;
        }

        public void AjouterParticipant(Participant participant)
        {
            concernes.Add(participant);
        }

        public void SupprimerParticipant(Participant participant)
        {
            concernes.Remove(participant);
        }

        public void CalculerBalanceDuneDepense(ref ListBox lb)
        {
            float montant = this.GetMontant();
            lb.Items.Add("" + this.GetLePayeur().GetName() + " : " + montant);
            float dette = 0;
            foreach(Participant p in this.GetConcerne())
            {
                dette = montant / this.GetConcerne().Count;
                if (p.Equals(this.GetLePayeur()))
                    lb.Items[0] = "" + p.GetName() + (montant - dette).ToString() + "€";
                else
                    lb.Items.Add("" + p.GetName() + " : " + (-dette) + "€");
            }
        }

        

    }
}
