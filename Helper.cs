using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal static class Helper
    {



        internal static int GetInputInt(string tag)
        {
            string temp;
            while (true)
            {
                temp = GetInputString(tag);
                if (int.TryParse(temp, out int temp2))
                {
                    return temp2;
                }
                else
                {
                    Console.WriteLine("måste skriva ett heltal!");
                }
            }
        }




        internal static string GetInputString(string tag)
        {
            string temp;

            while (true)
            {
                Console.WriteLine(tag);
                temp = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(temp) || string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Du måste skriva något!");
                }
                else
                {
                    return temp;
                }
            }
        }



    }
}
