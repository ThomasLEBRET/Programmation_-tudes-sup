using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.User
{
    /// <summary>
    /// Classe simulant un ORM pour la classe statique User
    /// </summary>
    public static class ORMUser
    {
        /// <summary>
        /// Vérifie qu'un utilisateur existe dans la base de données
        /// </summary>
        /// <param name="username">Le nom d'utilisateur</param>
        /// <returns>Un booléen : true si l'utilisateur existe, false sinon</returns>
        public static bool Exist(string username)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*)  FROM utilisateur WHERE USER = @user";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;

            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        /// <summary>
        /// Connecte un utilisateur 
        /// </summary>
        /// <param name="username">Le nom</param>
        /// <param name="password">Le mot de passe</param>
        /// <returns>Un booléen : true si la connexion de l'utilisateur a réussie, false sinon</returns>
        public static bool Connexion(string username, string password)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT *  FROM utilisateur WHERE USER = @user and MDP = @mdp";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = password;
            MySqlDataReader rdr = cmd.ExecuteReader();

            bool isUserExistant = false;
            if(rdr.Read())
            {
                User.SetUsername(rdr["USER"].ToString());
                User.SetTypeUser(rdr["CD_TYPE"].ToString());
                isUserExistant = true;
            }
            rdr.Close();
            return isUserExistant;
        }

        /// <summary>
        /// Inscrit un utilisateur en tant que joueur
        /// </summary>
        /// <param name="user">Le nom</param>
        /// <param name="mdp">le mot de passe</param>
        /// <returns></returns>
        public static bool Inscription(string user, string mdp)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "INSERT INTO utilisateur(USER, CD_TYPE, MDP) VALUES(@user, 'JOU', @mdp)";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = mdp;
            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
