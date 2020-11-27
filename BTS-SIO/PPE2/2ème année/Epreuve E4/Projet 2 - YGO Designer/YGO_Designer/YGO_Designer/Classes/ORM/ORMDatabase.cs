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
    /// <summary>
    /// Classe simulant un ORM pour un objet de tye MySqlConnection
    /// </summary>
    public static class ORMDatabase
    {
        private static MySqlConnection conn = null;

        /// <summary>
        /// Permet d'opérer une connexion entre le client applicatif et le serveur de base de données
        /// </summary>
        /// <returns>Un booléen : true si la connexion a pu s'opérer, false sinon</returns>
        public static bool Connexion()
        {
            conn = new MySqlConnection(Properties.Settings.Default.loginDist);
            conn.Open();
            return conn.State == System.Data.ConnectionState.Open;
        }

        /// <summary>
        /// Permet de fermer une connexion entre le client applicatif et le serveur de base de données
        /// </summary>
        /// <returns>Un booléen : true si la déconnexion a pu s'opérer, false sinon</returns>
        public static bool Deconnexion()
        {
            conn.Close();
            return conn.State == System.Data.ConnectionState.Closed;
        }

        /// <summary>
        /// Accesseur de l'objet MySqlConnection
        /// </summary>
        /// <returns>La connexion au format MySqlConnection</returns>
        public static MySqlConnection GetConn()
        {
            return conn;
        }
    }
}
