using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.Effet
{
    public class ORMEffet
    {
        public static List<Effet> GetEffetsCartes()
        {
            MySqlConnection conn = ORMDatabase.GetConn();
            List<Effet> effCartes = new List<Effet>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM effet";
            MySqlDataReader rdr = cmd.ExecuteReader();

            Effet e;
            while (rdr.Read())
                effCartes.Add(new Effet((string)rdr["CODE_EFFET"], (string)rdr["NOM_EFFET"]));
            rdr.Close();
            return effCartes;
        }
    }
}
