using System;

class Program
{
    static void Main(string[] args)
    {
        bool fortsette = true;
        while (fortsette)

        {
            // 1. Poproś o liczby
            Console.Write("Skriv inn et tall for tall1: ");
            int tall1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv inn et tall for tall2: ");
            int tall2 = Convert.ToInt32(Console.ReadLine());

            // 2. Pokaż sumę
            SkrivTall(tall1, tall2);

            // 3. Poproś o imię i wiek
            Console.Write("Skriv navnet ditt: ");
            string navn = Console.ReadLine();

            Console.Write("Hvor gammel er du? ");
            int alder = Convert.ToInt32(Console.ReadLine());

            // 4. Pokaż imię i komunikat
            Console.WriteLine($"Hei, {navn}!");
            Console.WriteLine(ReturnKomunikat(alder));



            // 5. Pauza przed zamknięciem
            Console.WriteLine("Trykk på en tast for å avslutte...");
            Console.ReadLine();


            Console.WriteLine("Vil du prøve igjen? (ja/nei)");
            string svar = Console.ReadLine().ToLower();

            if (svar == "ja")
            { fortsette = true; }
            else if (svar == "nei")
            {
                Console.WriteLine("Trykk på en tast for å avslutte...");
                fortsette = false;
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("Ugyldig svar, avslutter programmet.");

                fortsette = false;
                Console.WriteLine("Trykk på en tast for å avslutte...");

                Console.ReadLine();
            }



            Console.WriteLine();
        }
    }

    public static int ReturnWholeNumber(int numer1, int numer2)
    {
        return numer1 + numer2;
    }

    public static string ReturnKomunikat(int alder)
    {
        if (alder > 35)
        {
            return "Du er gammel.";
        }
        else
        {
            return "Du er ung.";
        }
    }

    public static void SkrivTall(int numer1, int numer2)
    {
        Console.WriteLine($"Summen av tallene {numer1} og {numer2} er: {ReturnWholeNumber(numer1, numer2)}");
    }
}
