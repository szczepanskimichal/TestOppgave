
class Program
{
    static void Main(string[] args) //Metoda
    {
        Console.WriteLine("Hva er navnet ditt?"); //Wyświetlamy tekst na ekranie
        var text = Console.ReadLine(); //Czekamy na naciśnięcie klawisza
        Console.WriteLine(text); // Wyświetlamy tekst na ekranie
        Console.ReadLine();
    }
}