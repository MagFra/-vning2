using Övning2.Helpers;

namespace Övning2
{
    internal class Loop
    {
        private static IHelperUI helper = null!;

        internal Loop(IHelperUI help) => helper = help;

        internal void Start()
        {
            string tempText = helper.GetInputString("Skriv en valfri text så repeterar jag den 10 gånger.");
            for (int i = 1; i <= 10; i++)
            {
                helper.WriteLine($"{i}\t{tempText}");
            }
            helper.WaitForUser("Tryck \"Enter\" för att fortsätta.");
        }
    }
}