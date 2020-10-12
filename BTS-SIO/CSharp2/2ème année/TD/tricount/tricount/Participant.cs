using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tricount
{
    class Participant : IComparable <Participant>
    {
        private string name;
        private float balance;
        private float monCoutTotal;
        private List<Depense> mesDepenses;

        public Participant(string name)
        {
            this.name = name;
            this.balance = 0;
            this.monCoutTotal = 0;
            mesDepenses = new List<Depense>();
        }

        public string GetName()
        {
            return this.name;
        }

        public float GetBalance()
        {
            return this.balance;
        }

        public float GetMonCoutTotal()
        {
            return this.monCoutTotal;
        }

        public List<Depense> GetMesDepenses()
        {
            return this.mesDepenses;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetBalance(float balance)
        {
            this.balance = balance;
        }

        public void SetMonCoutTotal(float monCoutTotal)
        {
            this.monCoutTotal = monCoutTotal;
        }

        public void SetMesDepenses(List<Depense> mesDepenses)
        {
            this.mesDepenses = mesDepenses;
        }

        public void AjouterDepense(Depense d)
        {
            mesDepenses.Add(d); //Ajout de la dépense à la liste dépense du payeurs
            if (this.Equals(d.GetLePayeur()))
                balance += d.GetMontant(); //balance du payeur augmente

            int nbrConcernes = d.GetConcerne().Count; //Compte le nombre de personnes concernées par la dépense
            if (d.GetConcerne().IndexOf(this) >= 0)
            {
                balance = (balance - (d.GetMontant() / nbrConcernes)); //Balance des personnes concernées diminue en fct du rapport montant / nbr personnes concernées par la dépense
                monCoutTotal += d.GetMontant() / nbrConcernes; //Cout total augmente du montant de la dépense sur le nbr de personne
            }
        }

        public void SupprimerDepense(Depense d)
        {
            mesDepenses.Remove(d);
            DonneesPubliques.GetMonTricount().GetListeDepenses().Remove(d);
        }

        public override string ToString()
        {
            return name;
        }

        public int CompareTo(Participant p)
        {
            return Math.Abs(p.balance).CompareTo(Math.Abs(this.balance));
        }

    }
}
