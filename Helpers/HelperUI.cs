using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Helpers
{
    public class HelperUI : IHelperUI
    {



        public int GetInputInt(string text, bool cls = false)
        {
            string temp;
            while (true)
            {
                // if (cls) { Console.Clear(); }
                temp = GetInputString(text, cls);
                if (int.TryParse(temp, out int temp2))
                {
                    return temp2;
                }
                else
                {
                    WaitForUser("Du måste skriva ett heltal!\nTryk \"Enter\" för att försöka igen.");
                }
            }
        }




        public string GetInputString(string text, bool cls = false)
        {
            string temp;

            while (true)
            {
                // if (cls) { Console.Clear(); }
                WriteLine(text, cls);
                temp = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(temp) || string.IsNullOrEmpty(temp))
                {
                    WaitForUser("Du måste skriva något!\nTryk \"Enter\" för att försöka igen.");
                }
                else
                {
                    return temp;
                }
            }
        }




        public void WriteLine(string text, bool cls = false)
        {
            if (cls) { Console.Clear(); }
            Console.WriteLine(text);
        }




        public void WaitForUser(string text)
        {
            WriteLine(text);
            string temp = Console.ReadLine()!;
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
