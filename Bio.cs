using Övning2.Helpers;

namespace Övning2
{
    internal class Bio
    {
        private static IHelperUI helper = null!;
        internal Bio(IHelperUI help) => helper = help;

        internal void Start()
        {
            Menus? menus = new Menus(helper);
            bool exit = false;
            while (!exit)
            {
                uint menuChois = menus.BioMenu();

                switch (menuChois)
                {
                    case (uint)BioMenuChoices.Avsluta: { exit = true; break; }
                    case (uint)BioMenuChoices.Person: { Person(); break; }
                    case (uint)BioMenuChoices.Grupp: { Grupp(); break; }
                    default: { helper.WaitForUser("Du kan bara välja alternativ från menyn.\nTryk \"Enter\" för att försöka igen.\n"); break; }
                }
            }
            menus = null;
        }




        private void Grupp()
        {
            bool exit = false;
            int AntalPersoner;

            while (!exit)
            {
                AntalPersoner = helper.GetInputInt("Hur många personer är det i gruppen?");
                if (AntalPersoner == 0) { exit = true; }
                else if (AntalPersoner < 2) { helper.WriteLine("En grupp bstår av minst två personer."); }
                else if (AntalPersoner > 150) { helper.WriteLine("Vår salong rymmer inte mer än 150 personer."); }
                else { exit = true; AskForGroupAges(AntalPersoner); }
            }
        }




        private void AskForGroupAges(int antalPersoner)
        {
            string initAgeQuestio, askForResonableAge;
            uint summa = 0;
            for (int i = 1; i <= antalPersoner; i++)
            {
                initAgeQuestio = $"Hur gammal är person {i} i gruppen?";
                askForResonableAge = $"Vänligen ange en rimlig ålder på person {i} i gruppen.";

                summa += SelectPrice(AskForAge(initAgeQuestio, askForResonableAge));
            }

            helper.WriteLine($"Gruppen innehåller {antalPersoner} st personer.\nTotalpriset är {summa} SEK.");
            helper.WaitForUser("Tryck \"Enter\" för att fortsätta.");
        }




        private void Person()
        {
            uint summa = 0;
                string initAgeQuestio = "Hur gammal är personen?";
            string askForResonableAge = "Vänligen ange en rimlig ålder på personen.";

                summa += SelectPrice(AskForAge(initAgeQuestio, askForResonableAge));

            helper.WriteLine($"Personens biljettpris är {summa} SEK.");
            helper.WaitForUser("Tryck \"Enter\" för att fortsätta.");
        }



        private int AskForAge(string initAgeQuestio, string askForResonableAge)
        {
            int age = 0;
            bool exit = false;
            while (!exit)
            {
                age = helper.GetInputInt(initAgeQuestio);
                if (age < 0 || age > 120)
                {
                    helper.WriteLine(askForResonableAge);
                }
                else
                {
                    exit = true;
                }
            }
            return age;
        }




        private static uint SelectPrice(int age)
        {
            if (age < 20) { return 80; } // Ungdomspris.
            if (age > 64) { return 90; } // Pensionärspris
            return 120; // Normalpris
        }
    }
}