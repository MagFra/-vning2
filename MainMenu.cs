using Övning2.Helpers;

namespace Övning2
{
        internal class MainMenu
    {
        private static IHelperUI helper = null!;
        private Bio? bio = null;
        private Loop? loop = null;
        private Tredje? tredje = null;
        public MainMenu(IHelperUI help) => helper = help;

        internal void StartHere()
        {
            Menus menus = new Menus(helper);
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
                            bio = new Bio(helper);
                            bio.Start();
                            bio = null;
                            break;
                        }
                    case (uint)MainMenuChoices.Loop:
                        {
                            loop = new Loop(helper);
                            loop.Start();
                            loop = null;
                            break;
                        }
                    case (uint)MainMenuChoices.Tredje:
                        {
                            tredje = new Tredje(helper);
                            tredje.Start();
                            tredje = null;
                            break;
                        }
                    default: { helper.WaitForUser("Du försöker välja utanför menyn!\nTryck på \"Enter\" för att göra ett nytt försök.\n"); break; }
                }
            }

        }
    }
}