using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace testTri
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enfant : string "pseudo"; string "mot de passe"; int : "score"  */
            ArrayList groupeEnfants = new ArrayList();
            Enfant eu = new Enfant("Thomas", "test", 7);
            Enfant ed = new Enfant("Steven", "test", 5);
            Enfant et = new Enfant("Aghiles", "test", 2);
            Enfant eq = new Enfant("Najib", "test", 9);
            Enfant ec = new Enfant("Tom", "test", 4);
            groupeEnfants.Add(eu);
            groupeEnfants.Add(ed);
            groupeEnfants.Add(et);
            groupeEnfants.Add(eq);
            groupeEnfants.Add(ec);
            /* Ici on compare 2 enfants par rapprt à leur score */
            int scoreEntreDeux = eu.CompareTo(ed);
            /*
             * scoreEntreDeux = 1 -> eu a le plus grand score par rapport à ed
             * scoreEntreDeux = -1 -> eu a le plus petit score par rapport à ed
             * scoreEntreDeux = 0 -> eu et ed ont le même score
             */
            if (scoreEntreDeux == 1)
            {
                Console.WriteLine("Le plus grand score entre "+eu.GetPseudo()+" et "+ed.GetPseudo()+" est :");
                Console.WriteLine(eu.GetPseudo()+" avec " + eu.GetScore() + " points");
            }
            groupeEnfants.Sort();
            /* La méthode Sort() tri désormais par rapport au score des enfants grâce à IComparable et à CompareTo */
            foreach(Enfant enf in groupeEnfants)
            {
                Console.WriteLine(enf.GetScore());
            }
            Console.ReadKey();
        }
    }
}
