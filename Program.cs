using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hva heter du? "); // Skriver ut tekst uten å flytte til ny linje
        string navn = Console.ReadLine(); // Leser brukerens navn

        Console.Write("Hvor gammel er du? "); // ← tu był błąd: { zamiast (
        string alderInput = Console.ReadLine();
        int alder = Convert.ToInt32(alderInput); // Konverterer tekst til tall

        // Kaller metoden og sender med navn og alder
        SkrivAlt(navn, alder);
    }

    // Metode som ikke returnerer noe, men skriver informasjon til konsollen
    public static void SkrivAlt(string navn, int alder)
    {
        Console.WriteLine($"Hei, {navn}!");
        Console.WriteLine($"Du er {alder} år gammel."); // ← tu był błąd: " zamiast $
    }
}
