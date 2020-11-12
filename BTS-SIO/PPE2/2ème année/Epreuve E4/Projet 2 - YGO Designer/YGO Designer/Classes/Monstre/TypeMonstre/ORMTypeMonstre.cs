using MySql.Data.MySqlClient;
using System.Collections.Generic;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer
{
    public static class ORMTypeMonstre
    {
        public static List<TypeMonstre> GetTypeMonstre()
        {
            MySqlConnection conn = ORMDatabase.GetConn();
            List<TypeMonstre> nomTypeM = new List<TypeMonstre>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM type_monstre";
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                nomTypeM.Add(new TypeMonstre((string)rdr["CODE_TYPE_MONSTRE"], (string)rdr["NOM_TYPE_MONSTRE"]));
            rdr.Close();
            return nomTypeM;
        }
    }
}