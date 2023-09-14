namespace Övning2
{
    internal class Runner
    {
        internal void StartHere()
        {
            Menu menu = new();
            int menuChoice;

            bool exit = false;
            while (!exit)
            {
                menuChoice = Menu.ViewAndChoose();

                switch (menuChoice) 
                { 
                    case (int)MenuChoices.Close: { exit = true; break; }
                    case (int)MenuChoices.Default: { Console.WriteLine("Du har nu fått fel meddelande!"); break; }
                }
            }
        }
    }
}