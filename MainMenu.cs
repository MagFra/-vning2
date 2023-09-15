using Övning2.Helpers;

namespace Övning2
{
        internal class MainMenu
    {
        private static IHelper helper = new Helper();
        internal void StartHere()
        {
            uint menuChoice;

            bool exit = false;
            while (!exit)
            {
                menuChoice = Menus.MainMenu();

                switch (menuChoice) 
                { 
                    case (uint)MainMenuChoices.Close: { exit = true; break; }
                    case (uint)MainMenuChoices.Bio:
                        {
                            Bio.Start();
                            break; 
                        }
                    default: { helper.WriteLine("Du försöker välja utanfö menyn!"); break; }
                }
            }

        }
    }
}