using System;
using System.Collections.Generic;
using System.Text;

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
