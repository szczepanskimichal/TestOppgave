using System;
using System.Xml.Linq;

void ThrowDice()
{
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine($"welcome {name}!");

    Random random = new Random(); // Przeniesiono tutaj



    while (true)
    {
        int numberOfThrownNumberOne = 0;
        for (int i = 0; i < 10; i++)
        {
            var diceThrow = GetRandomDice(random);
            if (diceThrow == 1)
            {
                numberOfThrownNumberOne++;
            }
            Console.WriteLine($"You rolled a {diceThrow}");
        }
        Console.WriteLine($"You rolled a 1 {numberOfThrownNumberOne} times");

        // Pytanie użytkownika, czy chce zagrać ponownie
        Console.WriteLine("Czy chcesz zagrać ponownie? (Y/N)");
        string answer = Console.ReadLine().ToUpper();

        if (answer == "N")
        {
            Console.WriteLine("Dziękujemy za grę! Program zostanie zamknięty.");
            break; // Zamyka pętlę i kończy program
        }
        else if (answer != "Y")
        {
            Console.WriteLine("Nieprawidłowy wybór. Program zostanie zamknięty.");
            break; // Zamyka pętlę i kończy program
        }
    }

    // Oczekiwanie na naciśnięcie klawisza przed zamknięciem
    Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
    Console.ReadKey();
}

int GetRandomDice(Random random)
{
    int diceResult = random.Next(1, 7);
    return diceResult;
}

ThrowDice();
