using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Monstre.Attribut_Monstre
{
    public static class ORMAttributMonstre
    {
        public static List<AttributMonstre> GetAttribMonstre()
        {
            MySqlConnection conn = ORMDatabase.GetConn();
            List<AttributMonstre> attrMon = new List<AttributMonstre>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM attribut_monstre";
            MySqlDataReader rdr = cmd.ExecuteReader();

            AttributMonstre am;
            while (rdr.Read())
                attrMon.Add(new AttributMonstre((string)rdr["CODE_ATTR_MO"], (string)rdr["NOM_ATTR_MO"]));
            rdr.Close();
            return attrMon;
        }
    }
}
