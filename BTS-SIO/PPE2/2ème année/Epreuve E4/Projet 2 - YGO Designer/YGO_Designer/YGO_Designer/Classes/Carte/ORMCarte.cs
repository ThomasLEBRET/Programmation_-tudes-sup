using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using YGO_Designer.Classes.ORM;
using System.Threading.Tasks;

namespace YGO_Designer.Classes.Carte
{
    /// <summary>
    /// Classe static simulant le comportement d'un ORM associé à l'objet Carte
    /// </summary>
    public static class ORMCarte
    {
        /// <summary>
        /// Méthode asynchrone renvoyant le nombre de cartes dans un objet Task
        /// </summary>
        /// <returns>Une tâche Task possédant un entier de type int</returns>
        public static async Task<int> GetNbr()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM carte";
            int res = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            return res; 
        }

        /// <summary>
        /// Méthode asynchrone renvoyant le nombre de carte ayant un attribut de type Monstre dans un objet Task
        /// </summary>
        /// <returns>Un objet tâche Task comportant un pourcentage de cartes monstres parmis les cartes de type float</returns>
        public static async Task<float> GetNbrMonstre()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM carte WHERE CODE_ATTR_CARTE = 'MON'";
            return ((Convert.ToInt32(cmd.ExecuteScalar()) * 100) /  (await GetNbr()));
        }

        /// <summary>
        /// Méthode asynchrone renvoyant le nombre de carte ayant un attribut de type Magie dans un objet Task
        /// </summary>
        /// <returns>Un objet tâche Task comportant un pourcentage de cartes monstres parmis les cartes de type float</returns>
        public static async Task<float> GetNbrMagie()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM carte WHERE CODE_ATTR_CARTE = 'MAG'";
            return ((Convert.ToInt32(cmd.ExecuteScalar()) * 100) / (await  GetNbr()));
        }

        /// <summary>
        /// Méthode asynchrone renvoyant le nombre de carte ayant un attribut de type Piege dans un objet Task
        /// </summary>
        /// <returns>Un objet tâche Task comportant un pourcentage de cartes monstres parmis les cartes de type float</returns>
        public static async Task<float> GetNbrPiege()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM carte WHERE CODE_ATTR_CARTE = 'PIE'";
            return ((Convert.ToInt32(cmd.ExecuteScalar()) * 100) / (await GetNbr()));
        }

        /// <summary>
        /// Vérifie qu'une carte est déjà existante dans une base de données
        /// </summary>
        /// <param name="c">Un objet de type Carte</param>
        /// <returns>Un booléen : true si la carte existe, false sinon</returns>
        public static bool Exist(Carte c)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*)  FROM carte WHERE NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = c.GetNo();

            return  Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        /// <summary>
        /// Permet de supprimer une carte de la base de données. Un trigger supprime la liste de ses effets avant la suppression 
        /// de la carte afin de respecter les contraintes d'unicités de la base de données (une carte est rattachée à une liste d'effets)
        /// </summary>
        /// <param name="c">Un objet de type Carte</param>
        /// <returns>Un booléen : true si la carte a pu être supprimée, false sinon</returns>
        public static bool Delete(Carte c)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "DELETE FROM carte WHERE NO_CARTE = @noC";
            cmd.Parameters.Add("@noC", MySqlDbType.Int16).Value = c.GetNo();

            return Convert.ToInt32(cmd.ExecuteNonQuery()) == 1;
        }

        /// <summary>
        /// Récupère l'ensemble des effets depuis la table 'effet'
        /// </summary>
        /// <returns>Une liste d'objets de type Effet</returns>
        public static List<Effet> GetEffets()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM effet";
            List<Effet> lE = new List<Effet>();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                lE.Add(new Effet(rdr["CODE_EFFET"].ToString(), rdr["NOM_EFFET"].ToString()));
            rdr.Close();
            return lE;
        }

        /// <summary>
        /// Récupère la liste des effets d'une carte
        /// </summary>
        /// <param name="noCarte">Le numéro de la carte</param>
        /// <returns>Une liste d'objets de type Effet</returns>
        public static List<Effet> GetEffetsByCard(int noCarte)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT E.* FROM effet_carte EC, effet E, carte C WHERE C.NO_CARTE = EC.NO_CARTE AND C.NO_CARTE = @noCarte AND EC.CODE_EFFET = E.CODE_EFFET";
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;

            List<Effet> lE = new List<Effet>();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                lE.Add(new Effet(rdr["CODE_EFFET"].ToString(), rdr["NOM_EFFET"].ToString()));
            rdr.Close();
            return lE;
        }

        /// <summary>
        /// Récupère une carte par son numéro
        /// </summary>
        /// <param name="noCarte">Le numéro d'une carte</param>
        /// <returns>Un objet de type Carte</returns>
        public static Carte GetByNo(int noCarte)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM carte WHERE NO_CARTE = @noCarte";

            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;

            Carte c = new Carte();
            string nom;
            Attribut attr = GetAttribut(noCarte);
            string description;
            List<Effet> eff = GetEffetsByCard(noCarte);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                nom = (string)rdr["NOM"];
                description = (string)rdr["DESCRIPTION"];

                //On construit un type de carte différent en fonction de l'attribut de la carte
                switch (attr.GetCdAttrCarte())
                {
                    case "MON":
                        string typeMo = (string)rdr["TYPE_MO"];
                        string attrMo = (string)rdr["ATTR_MO"];
                        int nivMo = Convert.ToInt32(rdr["NIVEAU_MO"]);
                        int atk = Convert.ToInt32(rdr["ATK"]);
                        int def = Convert.ToInt32(rdr["DEF"]);
                        string typeMoCarte = (string)rdr["TYPES_MONSTE_CARTE"];
                        c = new Monstre(typeMo, attrMo, nivMo, atk, def, typeMoCarte, eff, noCarte, attr, nom, description);
                        break;
                    case "MAG":
                        c = new Magie(eff, noCarte, attr, nom, description, (string)rdr["TYPE_MA"]);
                        break;
                    case "PIE":
                        c = new Piege(eff, noCarte, attr, nom, description, (string)rdr["TYPE_PI"]);
                        break;
                }
            }
            rdr.Close();
            return c;
        }

        /// <summary>
        /// Récupère une carte par son numéro au sein d'un deck
        /// </summary>
        /// <param name="noCarte">Le numéro de la carte</param>
        /// <param name="noDeck">Le numéro du deck</param>
        /// <returns>Un objet de type Carte</returns>
        public static Carte GetByNoForDeck(int noCarte, int noDeck)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT c.*, i.NB_EXEMPLAIRE FROM carte c, inclus i WHERE c.NO_CARTE = i.NO_CARTE AND i.NO_CARTE = @noCarte AND i.NO_DECK = @noDeck";

            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;
            cmd.Parameters.Add("@noDeck", MySqlDbType.Int32).Value = noDeck;

            Carte c = new Carte();
            string nom = "";
            Attribut attr = GetAttribut(noCarte);
            string description = "";
            int nbExemplaire = 0;
            List<Effet> eff = GetEffetsByCard(noCarte);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                nom = (string)rdr["NOM"];
                description = (string)rdr["DESCRIPTION"];
                nbExemplaire = Convert.ToInt16(rdr["NB_EXEMPLAIRE"]);
                switch (attr.GetCdAttrCarte())
                {
                    case "MON":
                        string typeMo = (string)rdr["TYPE_MO"];
                        string attrMo = (string)rdr["ATTR_MO"];
                        int nivMo = Convert.ToInt32(rdr["NIVEAU_MO"]);
                        int atk = Convert.ToInt32(rdr["ATK"]);
                        int def = Convert.ToInt32(rdr["DEF"]);
                        string typeMoCarte = (string)rdr["TYPES_MONSTE_CARTE"];
                        c = new Monstre(typeMo, attrMo, nivMo, atk, def, typeMoCarte, eff, noCarte, attr, nom, description, nbExemplaire);
                        break;
                    case "MAG":
                        c = new Magie (eff, noCarte, attr, nom, description, (string)rdr["TYPE_MA"], nbExemplaire);
                        break;
                    case "PIE":
                        c = new Piege(eff, noCarte, attr, nom, description, (string)rdr["TYPE_PI"], nbExemplaire);
                        break;
                }
            }
            rdr.Close();
            return c;
        }

        /// <summary>
        /// Récupère une liste de cartes correspondant partiellement au nom passé en paramètre de la méthode
        /// </summary>
        /// <param name="partName">Nom partiellement écrit afin de rechercher une série de cartes</param>
        /// <returns>Une liste typée Carte</returns>
        public static List<Carte> GetByPartialName(string partName)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT NO_CARTE FROM carte WHERE NOM LIKE '%" + partName + "%'";
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<List<Effet>> lE = new List<List<Effet>>();
            List<Effet> lEc = new List<Effet>();
            List<Attribut> lA = new List<Attribut>();
            List<int> lN = new List<int>();

            while (rdr.Read())
                lN.Add(Convert.ToInt32(rdr["NO_CARTE"]));
            rdr.Close();
            for(int i = 0; i < lN.Count; i++)
            {
                lE.Add(GetEffetsByCard(lN[i]));
                lA.Add(GetAttribut(lN[i]));
            }
            cmd.CommandText = "SELECT * FROM carte WHERE NOM LIKE '%" + partName + "%'";
            List<Carte> lC = new List<Carte>();
            Carte c = new Carte();
            int no;
            string nom;
            string description;
            Attribut at;

            int cursorCard = 0;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                no = lN[cursorCard];
                nom = (string)rdr["NOM"];
                description = (string)rdr["DESCRIPTION"];
                at = lA[cursorCard];
                switch (lA[cursorCard].GetCdAttrCarte())
                {
                    case "MON":
                        string typeMo = rdr["TYPE_MO"].ToString();
                        string attrMo = rdr["ATTR_MO"].ToString();
                        int nivMo = Convert.ToInt32(rdr["NIVEAU_MO"]);
                        int atk = Convert.ToInt32(rdr["ATK"]);
                        int def = Convert.ToInt32(rdr["DEF"]);
                        string typeMoCarte = (string)rdr["TYPES_MONSTE_CARTE"];
                        c = new Monstre(typeMo, attrMo, nivMo, atk, def, typeMoCarte, lE[cursorCard], no, at, nom, description);
                        break;
                    case "MAG":
                        c = new Magie(lE[cursorCard], no, at, nom, description, (string)rdr["TYPE_MA"]);
                        break;
                    case "PIE":
                        c = new Piege(lE[cursorCard], no, at, nom, description, (string)rdr["TYPE_PI"]);
                        break;
                }
                lC.Add(c);
                cursorCard++;
            }
            rdr.Close();
            return lC;
        }

        /// <summary>
        /// Récupère la liste des attributs existants pour les cartes
        /// </summary>
        /// <returns>Une liste typée Attribut</returns>
        public static List<Attribut> GetAttributs()
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM attribut_carte";
            List<Attribut> lA = new List<Attribut>();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                lA.Add(new Attribut(rdr["CODE_ATTR_CARTE"].ToString(), rdr["NOM_ATTR_CARTE"].ToString()));
            rdr.Close();
            return lA;
        }

        /// <summary>
        /// Récupère l'attribut d'une carte
        /// </summary>
        /// <param name="noCarte">Le numéro d'une carte</param>
        /// <returns>Un objet de type Attribut</returns>
        public static Attribut GetAttribut(int noCarte)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT AT.* FROM attribut_carte AT, carte C WHERE AT.CODE_ATTR_CARTE = C.CODE_ATTR_CARTE AND C.NO_CARTE = @noCarte";

            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;
            Attribut at = new Attribut();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
                at = new Attribut(rdr["CODE_ATTR_CARTE"].ToString(), rdr["NOM_ATTR_CARTE"].ToString());
            rdr.Close();
            return at;
        }

        /// <summary>
        /// Permet d'ajouter les effets d'une carte dans la tables effet_carte
        /// </summary>
        /// <param name="c">Un objet de type Carte</param>
        /// <returns>Un booléen : true si l'insertion de 0 ou n effets a réussie, false sinon</returns>
        public static bool AjouterEffetsCarte(Carte c)
        {
            if (c != null && ORMCarte.Exist(c))
            {
                MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
                cmd.CommandText = "INSERT INTO effet_carte(CODE_EFFET, NO_CARTE) VALUES(@cdEffet, @noCarte)";
                bool estTransactionReussi = true;
                cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = c.GetNo();
                MySqlParameter cdEffet = new MySqlParameter("@cdEffet", MySqlDbType.VarChar);
                cmd.Parameters.Add(cdEffet);
                if (estTransactionReussi)
                {
                    foreach (Effet e in c.GetListEffets())
                    {
                        cdEffet.Value = e.GetCode();
                        estTransactionReussi = cmd.ExecuteNonQuery() == 1;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
