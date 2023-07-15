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
        static public string[] comments_list = { "Круто", "Як захопливо", "Дякую", "Неймовірно не цікаво" };

        static public void comments_create()
        {
            Random rnd = new Random();

            for (int i = 0;i < rnd.Next(0,10);i++)
            {
                
            }
        }
    }
}
