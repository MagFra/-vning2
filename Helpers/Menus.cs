using System.Text;

namespace Övning2.Helpers
{
    internal class Menus
    {
        private static IHelperUI helper=null!;
        internal Menus(IHelperUI help) => helper = help;

        internal uint MainMenu()
        {
            StringBuilder temp = new();

            temp.Append($"Välkommen till Övnin2!\nVälg vad du vill göra:\n");
            temp.Append($"\n");
            temp.Append($"{(uint)MainMenuChoices.Close}. {MainMenuChoices.Close}");
            temp.Append($"\n");
            temp.Append($"{(uint)MainMenuChoices.Bio}. {MainMenuChoices.Bio}." +
                $"\t\t{MainMenuChoices.Bio} är ett program för att hjälpa en bio att begära\n\t\trätt pris för biljetter.\n" +
                $"\t\tBeroende på kundens ålder avgörs om ungdoms-,\n" +
                $"\t\tpensionärs- eller normalpris ska begäras.\n" +
                $"\t\tProgrammet hanterar även grupper.");
            temp.Append($"\n");
            temp.Append($"{(uint)MainMenuChoices.Loop}. {MainMenuChoices.Loop}.\tUpprepar en text tio gånger.");
            temp.Append($"\n");
            temp.Append($"{(uint)MainMenuChoices.Tredje}. {MainMenuChoices.Tredje}.\tHitta det tredje ordet i en valfri mening.");

            string temp2 = temp.ToString();

            // helper.Clear();

            return (uint)Math.Abs(helper.GetInputInt(text: temp2, cls: true));
        }


        internal uint BioMenu()
        {
            StringBuilder temp = new();

            temp.Append($"Välkommen till BIO!\nVälg vad du vill göra:\n");
            temp.Append($"\n");
            temp.Append($"{(uint)BioMenuChoices.Avsluta}. {BioMenuChoices.Avsluta}.");
            temp.Append($"\n");
            temp.Append($"{(uint)BioMenuChoices.Person}. {BioMenuChoices.Person}.\tBeräkna priset på en biljett, utifrån en persons ålder");
            temp.Append($"\n");
            temp.Append($"{(uint)BioMenuChoices.Grupp}. {BioMenuChoices.Grupp}.\tBeräkna totala kostnaden för en hel grupp,\n" +
                $"\t\tutifrån grupp deltagarnas åldrar.");

            string temp2 = temp.ToString();

            // helper.Clear();

            return (uint)Math.Abs(helper.GetInputInt(text: temp2, cls: true));
        }
    }
}