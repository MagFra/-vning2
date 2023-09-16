using Övning2.Helpers;

namespace Övning2
{
    internal class Tredje
    {
        private static IHelperUI helper = null!;

        internal Tredje(IHelperUI help) => helper = help;

        internal void Start()
        {
            string tempText = helper.GetInputString("Skriv in en valfri mening om minst tre ord, så finner jag det tredje ordet åt dig.");

            string[] split = tempText.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            helper.WriteLine($"\"{split[2]}\" är det tredje ordet.");
            helper.WaitForUser("Tryck \"Enter\" för att fortsätta.");
        }
    }
}