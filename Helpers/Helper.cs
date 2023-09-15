using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Helpers
{
    public class Helper : IHelper
    {



        public int GetInputInt(string tag)
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
                    WriteLine("måste skriva ett heltal!");
                }
            }
        }




        public string GetInputString(string tag)
        {
            string temp;

            while (true)
            {
                Console.WriteLine(tag);
                temp = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(temp) || string.IsNullOrEmpty(temp))
                {
                    WriteLine("Du måste skriva något!");
                }
                else
                {
                    return temp;
                }
            }
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
