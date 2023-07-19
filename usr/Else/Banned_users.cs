using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usr.Else
{
    internal class Banned_users
    {
        static public string[] Banned_users_list = { };

        static public void Banned_users_create(string user_name)
        {
            for (int i = 0; i < Banned_users_list.Length + 1; i++)
            {
                Banned_users_list[i] = user_name;
            }
        }
    }
}
