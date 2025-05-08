using System;

class Program
{
    static void Main(string[] args)
    {
        bool fortsette = true;
        while (fortsette)
        {
            int tall1, tall2;

            // Wprowadzenie pierwszej liczby
            while (true)
            {
                Console.Write("Skriv inn et tall for tall1: ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out tall1))
                    break;
                Console.WriteLine("Ugyldig input! Du må skrive inn et heltall.");
            }

            // Wprowadzenie drugiej liczby
            while (true)
            {
                Console.Write("Skriv inn et tall for tall2: ");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out tall2))
                    break;
                Console.WriteLine("Ugyldig input! Du må skrive inn et heltall.");
            }

            SkrivTall(tall1, tall2);

            // Imię
            string navn;
            while (true)
            {
                Console.Write("Skriv navnet ditt: ");
                navn = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(navn))
                    break;
                Console.WriteLine("Navnet kan ikke være tomt!");
            }

            // Wiek
            int alder;
            while (true)
            {
                Console.Write("Hvor gammel er du? ");
                string alderInput = Console.ReadLine();
                if (int.TryParse(alderInput, out alder))
                    break;
                Console.WriteLine("Ugyldig input! Du må skrive inn et tall for alder.");
            }

            Console.WriteLine($"Hei, {navn}!");
            Console.WriteLine(ReturnKomunikat(alder));

            Console.WriteLine("Vil du prøve igjen? (ja/nei)");
            string svar = Console.ReadLine().ToLower();

            if (svar == "ja")
            {
                fortsette = true;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Trykk på en tast for å avslutte...");
                Console.ReadLine();
                fortsette = false;
            }
        }
    }

    public static int ReturnWholeNumber(int numer1, int numer2)
    {
        return numer1 + numer2;
    }

    public static string ReturnKomunikat(int alder)
    {
        return alder > 35 ? "Du er gammel." : "Du er ung.";
    }

    public static void SkrivTall(int numer1, int numer2)
    {
        Console.WriteLine($"Summen av tallene {numer1} og {numer2} er: {ReturnWholeNumber(numer1, numer2)}");
    }
}
