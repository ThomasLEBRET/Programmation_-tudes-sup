using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YGO_Designer.Classes.ORM
{
    public static class ORMDatabase
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            conn = new MySqlConnection(Properties.Settings.Default.sConnection);
            conn.Open();
            return conn.State == System.Data.ConnectionState.Open;
        }

        public static bool Deconnexion()
        {
            conn.Close();
            return conn.State == System.Data.ConnectionState.Closed;
        }

        public static MySqlConnection GetConn()
        {
            return conn;
        }
    }
}
