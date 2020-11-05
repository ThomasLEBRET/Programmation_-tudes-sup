using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TPORM
{
    public static class ORMPlats
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            conn = new MySqlConnection(Properties.Settings.Default.sConnexion);
            conn.Open();
            if(conn.State.ToString() == "Open")
                return true;
            return false;
        }

        public static bool Deconnexion()
        {
            if (conn == null)
            {
                MessageBox.Show("La connexion n'est pas déclarée");
                return false;
            }
                

            if (conn.State.ToString() == "Open")
                conn.Close();

            if (conn.State.ToString() == "Closed")
                return true;

            return false;
        }
    }
}
