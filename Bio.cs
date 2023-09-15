namespace Övning2
{
    internal static class Bio
    {
        internal static void Start()
        {
            Console.WriteLine("Välkommen till BIO!");
            bool exit = false;
            while (!exit)
            {
                uint menuChois = Menus.BioMenu();

                switch (menuChois)
                {
                    case (uint)BioMenuChoices.Avsluta: { exit = true; break; }
                    case (uint)BioMenuChoices.Person: { EnPerson(); break; }
                    case (uint)BioMenuChoices.Grupp: { Grupp(); break; }
                }
            }
        }

        private static void Grupp()
        {
            throw new NotImplementedException();
        }

        private static void EnPerson()
        {
            throw new NotImplementedException();
        }
    }
}