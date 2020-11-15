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
