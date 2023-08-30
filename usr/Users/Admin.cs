using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usr.Users
{
    internal class Admin : User
    {
        List <string> banned_users = { };
        public string[] articles_created = { };

        public void ban_users()
        {
            
            int a = Convert.ToString(Console.ReadLine());
            banned_users.Add(a);
        }
    }
}
