namespace Övning2
{
    internal class MainMenu
    {
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
                    default: { Console.WriteLine("Du försöker välja utanfö menyn!"); break; }
                }
            }
        }
    }
}