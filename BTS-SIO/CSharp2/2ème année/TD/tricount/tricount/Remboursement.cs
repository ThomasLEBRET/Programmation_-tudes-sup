using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tricount
{
    class Remboursement
    {
        private Participant donneur;
        private Participant receveur;
        private float montant;

        public Remboursement(Participant donneur, Participant receveur, float montant)
        {
            this.donneur = donneur;
            this.receveur = receveur;
            this.montant = montant;
        }

        public Participant GetDonneur()
        {
            return this.donneur;
        }

        public Participant GetReceveur()
        {
            return this.receveur;
        }

        public float GetMontant()
        {
            return this.montant;
        }

        public void SetDonneur(Participant donneur)
        {
            this.donneur = donneur;
        }

        public void SetReceveur(Participant receveur)
        {
            this.receveur = receveur;
        }

        public void SetMontant(float montant)
        {
            this.montant = montant;
        }

        public override string ToString()
        {
            return "Le participant " + donneur + " a remboursé au participant " + receveur + " la somme de " + montant;
        }
        
    }
}
