using System.Text;

namespace Övning2
{
    internal class Menu
    {
        internal static int ViewAndChoose()
        {
            StringBuilder temp = new();

            temp.Append($"0. {MenuChoices.Close}");
            temp.Append($"\n");
            temp.Append($"1. {MenuChoices.Default}");

            string temp2 = temp.ToString();

            return GetInputInt(temp2);
        }




        private static int GetInputInt(string tag)
        {
            string temp;
            while (true)
            {
                temp = GetInputString(tag);
                if (int.TryParse(temp,out int temp2))
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