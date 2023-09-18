using Övning2.Helpers;

namespace Övning2
{
        internal class MainMenu
    {
        private static IHelperUI helper = Program.Helper;
        private Bio? bio;
        private Loop? loop;
        private Tredje? tredje;

        internal void StartHere()
        {
            Menus menus = new();
            uint menuChoice;

            bool exit = false;
            while (!exit)
            {
                menuChoice = menus.MainMenu();

                switch (menuChoice) 
                {
                    case (uint)MainMenuChoices.Close: { exit = true; helper.Clear(); break; }
                    case (uint)MainMenuChoices.Bio:
                        {
                            bio = new();
                            bio.Start();
                            bio = null;
                            GC.Collect();
                            break;
                        }
                    case (uint)MainMenuChoices.Loop:
                        {
                            loop = new();
                            loop.Start();
                            loop = null;
                            GC.Collect();
                            break;
                        }
                    case (uint)MainMenuChoices.Tredje:
                        {
                            tredje = new();
                            tredje.Start();
                            tredje = null;
                            GC.Collect();
                            break;
                        }
                    default: { helper.WaitForUser("Du försöker välja utanför menyn!\nTryck på \"Enter\" för att göra ett nytt försök.\n"); break; }
                }
            }

        }
    }
}