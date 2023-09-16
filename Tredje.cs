using Övning2.Helpers;

namespace Övning2
{
    internal class Tredje
    {
        private static IHelper helper = null!;

        internal Tredje(IHelper help) => helper = help;

        internal void Start()
        {
            string tempText = helper.GetInputString("Skriv in en valfri mening om minst tre ord, så finner jag det tredje ordet åt dig.");

            string[] split = tempText.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            helper.WriteLine($"\"{split[2]}\" är det tredje ordet.");
        }
    }
}