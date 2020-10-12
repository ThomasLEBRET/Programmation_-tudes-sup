using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voyage_class_test
{
    class Bagage
    {
        private int num;
        private float poids;
        private Passager proprietaire;

        public Bagage(int unNum, float unPoids, Passager unProprietaire)
        {
            num = unNum;
            poids = unPoids;
            proprietaire = unProprietaire;
        }

        public int GetNumero()
        {
            return num;
        }

        public float GetPoids()
        {
            return poids;
        }

        public Passager GetProprietaire()
        {
            return proprietaire;
        }

    }
}
