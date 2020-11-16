using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;

namespace YGO_Designer.Classes.User
{
    public static class ORMUser
    {
        public static bool ExistUser(string username)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT Count(*)  FROM utilisateur WHERE USER = @user";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;

            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        public static bool Connexion(string username, string password)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
            cmd.CommandText = "SELECT *  FROM utilisateur WHERE USER = @user and MDP = @mdp";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = password;
            MySqlDataReader rdr = cmd.ExecuteReader();

            bool estUserExistant = false;
            if(rdr.Read())
            {
                User.SetUsername(rdr["USER"].ToString());
                User.SetTypeUser(rdr["CD_TYPE"].ToString());
                User.SetPassword(rdr["MDP"].ToString());
                estUserExistant = true;
            }
            rdr.Close();
            return estUserExistant;
        }

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
