using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usr.Users
{
    internal class Admin : User
    {
        public string[] banned_users = { };
        public string[] articles_created = { };
    }
}
