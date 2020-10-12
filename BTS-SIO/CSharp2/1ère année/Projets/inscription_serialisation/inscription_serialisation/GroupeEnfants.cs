using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace inscription_serialisation
{
    [Serializable]
    class GroupeEnfants 
    {
        private static List<Enfant> groupeEnfants = new List<Enfant>();
        private static Enfant enfant;

        public static Enfant GetEnfant()
        {
            return enfant;
        }

        public static List<Enfant> GetGroupeEnfant()
        {
            return groupeEnfants;
        }

        public static void SetEnfant(Enfant monEnfant)
        {
            enfant = monEnfant;
        }

        public static void SetGroupeEnfant(List<Enfant> monGroupeEnfant)
        {
            groupeEnfants = monGroupeEnfant;
        }

        public static void AjouterEnfant(Enfant unEnfant)
        {
            groupeEnfants.Add(unEnfant);
        }

        public static void SupprimerEnfant(int unNumEnfant)
        {
            groupeEnfants.RemoveAt(unNumEnfant - 1);
        }

        public static bool EstPseudoExistant(string unPseudo)
        {
            if (groupeEnfants.Count() != 0)
            {
                foreach (Enfant enf in groupeEnfants)
                {
                    if (enf.GetPseudo() == unPseudo)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool EstMotDePasseExistant(string unMotDePasse)
        {
            foreach (Enfant enf in groupeEnfants)
            {
                if (enf.GetMotDePasse() == unMotDePasse)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EstEnfantExistant(string unPseudo, string unMotDePasse)
        {
            if (groupeEnfants.Count() != 0)
            {
                foreach (Enfant enf in groupeEnfants)
                {
                    if (enf.GetPseudo() == unPseudo && enf.GetMotDePasse() == unMotDePasse)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static void ClassementParScore(Form maFenetre)
        {
            groupeEnfants.Sort();
            int a = 1;
            foreach(Enfant enf in groupeEnfants)
            {
                Label label1 = new Label();
                label1.Text = (enf.GetPseudo() + " : " + enf.GetScore()).ToString();
                label1.Location = new Point(200, 40*a);
                label1.Font = new Font("Segoe Script", 12);
                label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);
                maFenetre.Controls.Add(label1);
                a++;
            }
        }

        public static void DeserialiseListe()
        {
            FileStream f = new FileStream("groupeEnfant.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            List<Enfant> unGroupeEnfants = new List<Enfant>();
            GroupeEnfants.SetGroupeEnfant((List<Enfant>)bf.Deserialize(f));
            f.Close();
        }

        public static void SerialiseListe()
        {
            FileStream f = new FileStream("groupeEnfant.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, GroupeEnfants.GetGroupeEnfant());
            f.Close();
        }
    }
}
