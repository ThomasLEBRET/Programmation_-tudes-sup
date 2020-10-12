using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voyage_class_test
{
    class Soute
    {
        private ArrayList listeBagage;

        public Soute()
        {
            listeBagage = new ArrayList();
        }

        public void AjouterBagage(Bagage bag)
        {
            listeBagage.Add(bag);
        }

        public float PoidsBagages(Passager unPassager)
        {
            float cumulPassager = 0;
            foreach (Bagage b in listeBagage)
            {
                if (b.GetProprietaire() == unPassager)
                    cumulPassager += b.GetPoids();
            }
            return cumulPassager;
        }

        public float PoidsTotal()
        {
            float cumulPoids = 0;
            foreach(Bagage b in listeBagage)
            {
                cumulPoids += b.GetPoids();
            }
            return cumulPoids;
        }
    }
}
