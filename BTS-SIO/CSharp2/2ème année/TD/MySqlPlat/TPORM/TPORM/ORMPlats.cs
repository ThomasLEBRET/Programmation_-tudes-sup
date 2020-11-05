using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TPORM
{
    public static class ORMPlats
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            conn = new MySqlConnection(Properties.Settings.Default.sConnexion);
            if (conn.State.Equals("Open"))
                return true;
            return false;
        }

        public static bool Deconnexion()
        {
            if (conn == null)
                return false;

            if (conn.State.Equals("Open"))
                conn.Close();

            if (conn.State.Equals("Close"))
                return true;

            return false;
        }
    }
}
