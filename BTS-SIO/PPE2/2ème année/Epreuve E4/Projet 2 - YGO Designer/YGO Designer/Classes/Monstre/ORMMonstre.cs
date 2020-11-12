using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public static class ORMMonstre
    {
        public static List<int> GetNbrEtoiles()
        {
            MySqlConnection conn = ORMDatabase.GetConn();
            List<int> nbrEtoiles = new List<int>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT NBR_ETOILE FROM etoile WHERE NBR_ETOILE > 0";
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                nbrEtoiles.Add((Int16)rdr["NBR_ETOILE"]);
            rdr.Close();
            return nbrEtoiles;
        }

        public static bool AjouterMonstre(Classes.Carte.Monstre m)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();

            cmd.CommandText = "INSERT INTO carte(NO_CARTE, CODE_ATTR_CARTE, NOM, DESCRIPTION) VALUES (@noC, @cdAttrC, @nomC, @descriptC)";
            cmd.Parameters.Add("@noC", MySqlDbType.Int32).Value = m.GetNo();
            cmd.Parameters.Add("@cdAttrC", MySqlDbType.VarChar).Value = m.GetCdAttr().GetCodeAttribut();
            cmd.Parameters.Add("@nomC", MySqlDbType.VarChar).Value = m.GetNom();
            cmd.Parameters.Add("@descriptC", MySqlDbType.VarChar).Value = m.GetDescription();

            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
