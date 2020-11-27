using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Deck
{
    /// <summary>
    /// Classe static simulant un ORM associé à l'objet Deck
    /// </summary>
    public static class ORMDeck
    {
        /// <summary>
        /// Méthode privée récupérant le nombre d'exemplaire d'une carte inclus dans un Deck
        /// </summary>
        /// <param name="noDeck">Le numéro du Deck</param>
        /// <param name="noCarte">Le numéro d'une Carte</param>
        /// <returns></returns>
        private static int NbExemplaireCard(int noDeck, int noCarte)
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

        /// <summary>
        /// Méthode privée vérifiant si un Deck existe
        /// </summary>
        /// <param name="noDeck">Le numéro d'un Deck</param>
        /// <returns>Un booléen : true si le deck existe, false sinon</returns>
        private static bool Exist(int noDeck)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT NO_DECK FROM inclus WHERE NO_DECK = @noDeck";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            MySqlDataReader rdr = cmd.ExecuteReader();
            bool exist = false;

            if(rdr.Read())
                exist = true;
            
            rdr.Close();
            return exist;
        }

        /// <summary>
        /// Ajoute un deck vierge
        /// </summary>
        /// <param name="d">Un objet de type Deck</param>
        /// <returns>Un booléen : true si le deck a été ajouté, false sinon</returns>
        public static bool Add(Deck d)
        {
            if (Exist(d.GetNo()))
                return false;

            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "INSERT INTO deck(NO_DECK, USER, NOM_DECK) VALUES(@no, @user, @nom)";
            cmd.Parameters.Add("@no", MySqlDbType.Int32).Value = d.GetNo();
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = d.GetNom();
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }

        /// <summary>
        /// Ajoute une carte dans un deck
        /// </summary>
        /// <param name="numCarte">Le numéro d'une carte</param>
        /// <param name="numDeck">Le numéro d'un deck</param>
        /// <returns>Un booléen : true si la carte a pu être ajoutée au deck, false sinon</returns>
        public static bool AddCard(int numCarte, int numDeck)
        {
            string userName = User.User.GetUsername();
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            if (NbExemplaireCard(numDeck, numCarte) == 0)
                cmd.CommandText = "INSERT INTO inclus(NO_DECK, NO_CARTE, NB_EXEMPLAIRE) VALUES(@noDeck, @noCarte, 1)";
            else
                if (NbExemplaireCard(numDeck, numCarte) <= 2)
                    cmd.CommandText = "UPDATE inclus SET NB_EXEMPLAIRE = NB_EXEMPLAIRE + 1 WHERE NO_DECK = @noDeck AND NO_CARTE = @noCarte";
                else
                    return false;
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = numDeck;
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = numCarte;
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }

        /// <summary>
        /// Récupère une liste de decks associés à un joueur
        /// </summary>
        /// <returns>Une liste typée Deck</returns>
        public static List<Deck> GetByUser()
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
            foreach(Deck d in ld)
                d.SetCartes(ORMDeck.GetCartes(d.GetNo()));
            return ld;
        }

        /// <summary>
        /// Récupère les cartes d'un deck
        /// </summary>
        /// <param name="noDeck">Le numéro d'un deck</param>
        /// <returns>Une liste typée Carte</returns>
        public static List<Carte.Carte> GetCartes(int noDeck)
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
                listCartes.Add(ORMCarte.GetByNoForDeck(i, noDeck));
            return listCartes;
        }

        /// <summary>
        /// Procédure supprimant les cartes d'un deck 
        /// </summary>
        /// <param name="noDeck">Le numéro du deck</param>
        public static void DeleteCards(int noDeck)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "DELETE FROM inclus WHERE NO_DECK = @noDeck";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Méthode suprimant une carte d'un deck
        /// </summary>
        /// <param name="c">Un objet de type Carte</param>
        /// <param name="d">Un objet de type Deck</param>
        /// <returns>Un booléen : true si la carte a pu être supprimée du deck, false sinon</returns>
        public static bool DeleteCard(Carte.Carte c, Deck d)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "DELETE FROM inclus WHERE NO_DECK = @noDeck AND NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = d.GetNo();
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = c.GetNo();
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }

        public static bool RemoveCopyCard(Carte.Carte c, Deck d)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "UPDATE inclus SET NB_EXEMPLAIRE = NB_EXEMPLAIRE - 1 WHERE NO_DECK = @noDeck AND NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = d.GetNo();
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = c.GetNo();
            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }
    }
}
