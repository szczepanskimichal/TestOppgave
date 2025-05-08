class Program
{
    static void Main(string[] args) //Metode
    {
        var name = Ask("What is your name? "); //Variabel

        var location = Ask("Where do you live? "); //Variabel
        Console.WriteLine($"Hei, {name}. Du bor i {location}"); //Interpolering
    }

    static string Ask(string question)
    {
        Console.Write(question);
        return Console.ReadLine();
    }

}
