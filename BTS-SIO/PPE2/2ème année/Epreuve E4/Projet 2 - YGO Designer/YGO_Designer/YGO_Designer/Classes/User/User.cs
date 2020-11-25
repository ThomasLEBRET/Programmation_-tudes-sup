using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.Carte;

namespace YGO_Designer.Classes.User
{
    public static class User
    {
        private static string username;
        private static string typeUser;
        private static string mdp;

        public static string GetUsername()
        {
            return username;
        }

        public static string GetTypeuser()
        {
            return typeUser;
        }


        public static void SetUsername(string newUser)
        {
            username = newUser;
        }

        public static void SetTypeUser(string newTypeUser)
        {
            typeUser = newTypeUser;
        }

        public static void SetPassword(string newMdp)
        {
            mdp = newMdp;
        }
    }
}
