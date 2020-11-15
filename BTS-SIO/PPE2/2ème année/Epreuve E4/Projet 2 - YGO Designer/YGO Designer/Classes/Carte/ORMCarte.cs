using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Carte
{
    public static class ORMCarte
    {
        public static bool ExistCard(Carte c)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*)  FROM carte WHERE NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = c.GetNo();

            return  Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

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

        public static List<Effet> GetEffetsCarte(int noCarte)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM effet_carte WHERE NO_CARTE = @noCarte";
            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;

            List<Effet> lE = new List<Effet>();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                lE.Add(new Effet(rdr["CODE_EFFET"].ToString(), rdr["NOM_EFFET"].ToString()));
            rdr.Close();
            return lE;
        }

        public static Carte GetCarte(int noCarte)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT * FROM carte WHERE NO_CARTE = @noCarte";

            cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = noCarte;
            
            Carte c = new Carte();
            string nom;
            Attribut attr = GetAttribut(noCarte);
            string description;
            List<Effet> eff = GetEffetsCarte(noCarte);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                nom = (string)rdr["NOM"];
                description = (string)rdr["DESCRIPTION"];

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

        public static bool AjouterEffetsCarte(Carte c)
        {
            if (c != null && ORMCarte.ExistCard(c))
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
                        cdEffet.Value = e.GetCodeEffet();
                        estTransactionReussi = cmd.ExecuteNonQuery() == 1;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
