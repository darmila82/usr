using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using usr;


namespace usr.Else
{
    internal class Comment 
    {
        static public string[] comments_list = {};

        static public void comments_create(string comment)
        {
            for (int i = 0;i < comments_list.Length+1; i++)
            {
                comments_list[i] = comment;
            }
        }
    }
}
