using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tricount
{
    static class DonneesPubliques
    {
        private static Participant moi;
        private static Tricount monTricountSelect;
        private static List<Tricount> mesTricounts;
        private static Depense uneDepense;


        public static Participant GetParticipantMoi()
        {
            return moi;
        }

        public static Tricount GetMonTricount()
        {
            return monTricountSelect;
        }

        public static List<Tricount> GetMesTricounts()
        {
            return mesTricounts;
        }

        public static Depense GetUneDepense()
        {
            return uneDepense;
        }

        public static void SetParticipantMoi(Participant monParticipant)
        {
            moi = monParticipant;
        }

        public static void SetMonTricount(Tricount monTricount)
        {
            monTricountSelect = monTricount;
        }

        public static void SetMaListeTricounts(List<Tricount> maListeTricount)
        {
            mesTricounts = maListeTricount;
        }

        public static void SetUneDepense(Depense laDepense)
        {
            uneDepense = laDepense;
        }

        public static void AjouterTricount(Tricount t)
        {
            mesTricounts.Add(t);
        }

        public static void AfficherTricount(ref ListBox listeFormTricounts)
        {
            listeFormTricounts.Items.Clear();
            foreach (Tricount t in mesTricounts)
                listeFormTricounts.Items.Add(t.GetName() + " créé par " + t.GetNomCreateur());
        }

        public static void SupprimerTricount(Tricount t)
        {
            mesTricounts.Remove(t);
        }

    }
}
