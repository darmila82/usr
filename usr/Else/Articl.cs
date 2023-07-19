using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usr.Else
{
    internal class Articl
    {
        static public string[] articles_list = { };

        static public void articles_create(string article)
        {
            for (int i = 0; i < articles_list.Length + 1; i++)
            {
                articles_list[i] = article;
            }
        }
    }
}
