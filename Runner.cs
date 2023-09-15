namespace Övning2
{
    internal class Runner
    {
        internal void StartHere()
        {
            Menu menu = new();
            uint menuChoice;

            bool exit = false;
            while (!exit)
            {
                menuChoice = Menu.ViewAndChoose();

                switch (menuChoice) 
                { 
                    case (uint)MenuChoices.Close: { exit = true; break; }
                    case (uint)MenuChoices.Default: { Console.WriteLine("Du har nu fått fel meddelande!"); break; }
                }
            }
        }
    }
}