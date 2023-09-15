using System.Text;

namespace Övning2.Helpers
{
    internal static class Menus
    {
        internal static uint MainMenu()
        {
            StringBuilder temp = new();

            temp.Append($"{(uint)MainMenuChoices.Close}. {MainMenuChoices.Close}");
            temp.Append($"\n");
            temp.Append($"{(uint)MainMenuChoices.Bio}. {MainMenuChoices.Bio}. Ett program för att hjälpa en bio att begära rätt pris för biljetter. Beroende på om kundens ålder avgörs om ungdoms-, pensionärs- eller normalpris ska begäras.Programmet hanterar även grupper.");

            string temp2 = temp.ToString();

            return (uint)Math.Abs(Helper.GetInputInt(temp2));
        }


        internal static uint BioMenu()
        {
            StringBuilder temp = new();

            temp.Append($"{(uint)BioMenuChoices.Avsluta}. {BioMenuChoices.Avsluta}.");
            temp.Append($"\n");
            temp.Append($"{(uint)BioMenuChoices.Person}. {BioMenuChoices.Person}.");
            temp.Append($"\n");
            temp.Append($"{(uint)BioMenuChoices.Grupp}. {BioMenuChoices.Grupp}.");

            string temp2 = temp.ToString();

            return (uint)Math.Abs(Helper.GetInputInt(temp2));
        }
    }
}