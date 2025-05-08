using System;

class Program
{
    static void Main(string[] args)
    {
        // Be brukeren om å skrive inn to tall
        Console.Write("Skriv inn et tall for tall1: ");
        int tall1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Skriv inn et tall for tall2: ");
        int tall2 = Convert.ToInt32(Console.ReadLine());

        // Kall på metoden som skriver ut summen
        SkrivTall(tall1, tall2);

        // Legger til en pause, så programmet ikke lukker seg umiddelbart
        Console.WriteLine("Trykk på en tast for å avslutte...");
        Console.ReadLine(); // Dette gjør at programmet venter på at brukeren trykker på en tast!!!!!!!
    }

    // Metode som returnerer summen av to tall
    public static int ReturnWholeNumber(int numer1, int numer2)
    {
        return numer1 + numer2;
    }

    // Metode som skriver ut summen av tallene
    public static void SkrivTall(int numer1, int numer2)
    {
        Console.WriteLine($"Summen av tallene {numer1} og {numer2} er: {ReturnWholeNumber(numer1, numer2)}");
    }
}
