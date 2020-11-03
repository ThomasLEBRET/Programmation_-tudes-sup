using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;


namespace testBaseDeDonnees
{
    static class Datas
    {
        public static MySqlConnection createConnexion(string serveur, string user, string password, string database)
        {
            return new MySqlConnection(@"server="+ serveur +";user="+ user +";password"+ password +"=;database="+ database +"");
        }

        public static void closeConnexion(MySqlConnection connexion)
        {
            connexion.Close();
        }
    }
}
