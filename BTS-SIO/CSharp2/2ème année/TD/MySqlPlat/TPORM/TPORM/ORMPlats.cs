using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using plat;

namespace TPORM
{
    public static class ORMPlats
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            conn = new MySqlConnection(Properties.Settings.Default.sConnexion);
            conn.Open();
            return conn.State == System.Data.ConnectionState.Open;
        }

        public static bool Deconnexion()
        {
            conn.Close();
            return conn.State == System.Data.ConnectionState.Closed;
        }

        public static int GetNbPlats()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Count(*) as nbPlats FROM plat";
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int nbPlats = Convert.ToInt16(rdr["nbPlats"]);
            rdr.Close();
            return nbPlats;
        }

        private static bool EstPlatExistant(string nom)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM plat WHERE nom = @nom";
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        public static List<Categorie> GetCategories()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT categorie FROM plat GROUP BY categorie";
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Categorie> lc = new List<Categorie>();
            while(rdr.Read())
                lc.Add((Categorie)Enum.Parse(typeof(Categorie), (string)rdr["categorie"]));
            rdr.Close();
            return lc;
        }

        public static bool ModifierPlat(Plat p)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE plat SET categorie = @categorie, nbcalories = @nbcalories, glutenFree = @glutenFree, vegan = @vegan WHERE nom = @nom";

            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = p.GetNom();
            cmd.Parameters.Add("@categorie", MySqlDbType.Enum).Value = p.GetCategorie();
            cmd.Parameters.Add("@prix", MySqlDbType.Int32).Value = p.GetPrix();
            cmd.Parameters.Add("@nbcalories", MySqlDbType.Int32).Value = p.GetNbcalories();
            cmd.Parameters.Add("@glutenFree", MySqlDbType.Int32).Value = p.GetGlutenFree();
            cmd.Parameters.Add("@vegan", MySqlDbType.Int32).Value = p.GetVegan();
            MessageBox.Show(""+Convert.ToInt32(cmd.ExecuteScalar()));
     
            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        public static List<Plat> AfficherPlats()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM plat";
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Plat> lp = new List<Plat>();
            while(rdr.Read())
            {
                Plat p = new Plat((string)rdr["nom"], (Categorie)Enum.Parse(typeof(Categorie), (string)rdr["categorie"]), (int)rdr["prix"], (int)rdr["nbCalories"], (bool)rdr["glutenFree"], (bool)rdr["vegan"]);
                lp.Add(p);
            }
            rdr.Close();
            return lp;
        }

        public static bool AjouterPlat(Plat p)
        {
            if (EstPlatExistant(p.GetNom()))
                return false;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO plat(nom, categorie, prix, nbcalories, glutenFree, vegan) VALUES(@nom, @categorie, @prix, @nbcalories, @glutenFree, @vegan)";

            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = p.GetNom();
            cmd.Parameters.Add("@categorie", MySqlDbType.Enum).Value = p.GetCategorie();
            cmd.Parameters.Add("@prix", MySqlDbType.Int32).Value = p.GetPrix();
            cmd.Parameters.Add("@nbcalories", MySqlDbType.Int32).Value = p.GetNbcalories();
            cmd.Parameters.Add("@glutenFree", MySqlDbType.Int32).Value = p.GetGlutenFree();
            cmd.Parameters.Add("@vegan", MySqlDbType.Int32).Value = p.GetVegan();

            return cmd.ExecuteNonQuery() == 1;
        }

        public static Plat GetPlatMoinsCher()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM plat WHERE prix = (SELECT MIN(prix) FROM plat)";
            MySqlDataReader rdr = cmd.ExecuteReader();
            Plat p = new Plat();
            if (rdr.Read())
            {
                p.SetNom((string)rdr["nom"]);
                p.SetCategorie((Categorie)Enum.Parse(typeof(Categorie), (string)rdr["categorie"]));
                p.SetPrix((int)rdr["prix"]);
                p.SetNbCalories((int)rdr["nbcalories"]);
                p.SetGlutenFree((bool)rdr["glutenFree"]);
                p.SetVegan((bool)rdr["vegan"]);

            }
            rdr.Close();
            return p;
        }

        public static List<Plat> GetPlatsByCategorie(Categorie c)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM plat WHERE categorie = @categorie";
            cmd.Parameters.Add("@categorie", MySqlDbType.Enum).Value = c;
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Plat> lp = new List<Plat>();
            while(rdr.Read())
            {
                Plat p = new Plat((string)rdr["nom"], (Categorie)Enum.Parse(typeof(Categorie), (string)rdr["categorie"]), (int)rdr["prix"], (int)rdr["nbCalories"], (bool)rdr["glutenFree"], (bool)rdr["vegan"]);
                lp.Add(p);
            }
            rdr.Close();
            return lp;
        }

        public static bool DeletePlat(Plat p)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM plat WHERE nom = @nom";
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = p.GetNom();
            return cmd.ExecuteNonQuery() == 1;
        }

        public static Plat GetPlatPlusCalorique()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM plat WHERE nbcalories = (SELECT MAX(nbcalories) FROM plat)";
            MySqlDataReader rdr = cmd.ExecuteReader();
            string nom = "unknow";
            Plat p = new Plat();
            if (rdr.Read())
            {
                p.SetNom((string)rdr["nom"]);
                p.SetCategorie((Categorie)Enum.Parse(typeof(Categorie), (string)rdr["categorie"]));
                p.SetPrix((int)rdr["prix"]);
                p.SetNbCalories((int)rdr["nbcalories"]);
                p.SetGlutenFree((bool)rdr["glutenFree"]);
                p.SetVegan((bool)rdr["vegan"]);

            }
            rdr.Close();
            return p;
        }

        public static float GetPrixMoyen()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AVG(prix) as moyennePrix FROM plat";
            MySqlDataReader rdr = cmd.ExecuteReader();
            float moyenne = 0;
            if (rdr.Read())
                moyenne = Convert.ToSingle(rdr["moyennePrix"]);
            rdr.Close();
            return moyenne;
        }
    }
}
