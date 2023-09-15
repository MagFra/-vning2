using System.Text;

namespace Övning2
{
    internal class Menu
    {
        internal static uint ViewAndChoose()
        {
            StringBuilder temp = new();

            temp.Append($"0. {MenuChoices.Close}");
            temp.Append($"\n");
            temp.Append($"1. {MenuChoices.Default}");

            string temp2 = temp.ToString();

            return (uint)Math.Abs(Helper.GetInputInt(temp2));
        }
    }
}