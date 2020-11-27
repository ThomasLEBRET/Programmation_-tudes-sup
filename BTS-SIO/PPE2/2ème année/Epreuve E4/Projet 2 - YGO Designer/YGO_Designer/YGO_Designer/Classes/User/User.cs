using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.Carte;

namespace YGO_Designer.Classes.User
{
    /// <summary>
    /// Classe static représentant un utilisateur
    /// </summary>
    public static class User
    {
        private static string username;
        private static string typeUser;

        /// <summary>
        /// Accesseur du nom d'utilisateur
        /// </summary>
        /// <returns>Le nom d'utilisateur</returns>
        public static string GetUsername()
        {
            return username;
        }

        /// <summary>
        /// Accesseur du type d'utilisateur
        /// </summary>
        /// <returns>Le type d'utilisateur</returns>
        public static string GetTypeuser()
        {
            return typeUser;
        }

        /// <summary>
        /// Mutateur du nom d'utilisateur
        /// </summary>
        /// <param name="newUser">Le nouveau nom d'utilisateur</param>
        public static void SetUsername(string newUser)
        {
            username = newUser;
        }

        /// <summary>
        /// Mutateur du type d'utilisateur
        /// </summary>
        /// <param name="newTypeUser">Le nouveau type d'utilisateur</param>
        public static void SetTypeUser(string newTypeUser)
        {
            typeUser = newTypeUser;
        }
    }
}
