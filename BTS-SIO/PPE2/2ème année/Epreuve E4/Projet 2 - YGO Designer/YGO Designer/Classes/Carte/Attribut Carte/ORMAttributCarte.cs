using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Carte.Attribut_Carte
{
    public static class ORMAttributCarte
    {
        public static List<AttributCarte> GetAttributsCartes()
        {
            MySqlConnection conn = ORMDatabase.GetConn();
            List<AttributCarte> attrCarte = new List<AttributCarte>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM attribut_carte";
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                attrCarte.Add(new AttributCarte((string)rdr["CODE_ATTR_CARTE"], (string)rdr["NOM_ATTR_CARTE"]));
            rdr.Close();
            return attrCarte;
        }
    }
}
