using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Deck
{
    public static class ORMDeck
    {
        private static int NbExemplaireCartesDansDeck(int noDeck, int noCarte)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT NB_EXEMPLAIRE FROM inclus WHERE NO_DECK = @noDeck AND NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;
            MySqlDataReader rdr = cmd.ExecuteReader();
            int res = 0;
            if(rdr.Read())
                res = Convert.ToInt16(rdr["NB_EXEMPLAIRE"]);
            rdr.Close();
            return res;
        }
        private static bool EstDeckExistant(int noDeck)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT NO_DECK FROM inclus WHERE NO_DECK = @noDeck AND ";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            MySqlDataReader rdr = cmd.ExecuteReader();
            bool estValide = false;

            if(rdr.Read())
                estValide = true;
            
            rdr.Close();
            return estValide;
        }

        public static bool AjouteDeck(Deck d)
        {
            if (EstDeckExistant(d.GetNoDeck()))
                return false;

            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "INSERT INTO deck(NO_DECK, USER, NOM_DECK) VALUES(@no, @user, @nom)";
            cmd.Parameters.Add("@no", MySqlDbType.Int32).Value = d.GetNoDeck();
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = d.GetNom();
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }

        public static bool AjouteCarteADeck(int numCarte, int numDeck)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            if (NbExemplaireCartesDansDeck(numDeck, numCarte) == 0)
                cmd.CommandText = "INSERT INTO inclus(NO_DECK, NO_CARTE, NB_EXEMPLAIRE) VALUES(@noDeck, @noCarte, 1)";
            else
                if (NbExemplaireCartesDansDeck(numDeck, numCarte) <= 2)
                    cmd.CommandText = "UPDATE inclus SET NB_EXEMPLAIRE = NB_EXEMPLAIRE + 1 WHERE NO_DECK = @noDeck AND NO_CARTE = @noCarte";
                else
                    return false;
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = numDeck;
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = numCarte;
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }
        public static List<Deck> GetDecksForUser()
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM deck WHERE USER = @user";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = userName;
            List<Deck> ld = new List<Deck>();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
                ld.Add(new Deck(Convert.ToInt32(rdr["NO_DECK"]), (string)rdr["USER"], (string)rdr["NOM_DECK"]));
            rdr.Close();
            return ld;
        }

        public static List<Carte.Carte> GetCartesForADeck(int noDeck)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT NO_CARTE FROM inclus WHERE NO_DECK = @noDeck";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            List<int> lNbCartes = new List<int>();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                lNbCartes.Add(Convert.ToInt32(rdr["NO_CARTE"]));
            rdr.Close();

            List<Carte.Carte> listCartes = new List<Carte.Carte>();
            foreach (int i in lNbCartes)
                listCartes.Add(ORMCarte.GetCarteByNo(i));
            return listCartes;
        }
        public static void ViderDeck(int noDeck)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "DELETE FROM inclus WHERE NO_DECK = @noDeck";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            cmd.ExecuteNonQuery();
        }
    
    }
}
