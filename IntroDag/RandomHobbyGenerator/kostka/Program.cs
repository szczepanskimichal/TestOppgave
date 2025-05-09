using System;

void ThrowDice()
{
    // Jeg ber brukeren skrive inn navnet sitt
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine($"Welcome, {name}!");

    // Jeg oppretter et Random-objekt for å generere tilfeldige terningkast
    Random random = new Random();

    while (true) // Jeg bruker en løkke for å la brukeren spille flere runder
    {
        int numberOfThrownNumberOne = 0; // Jeg teller hvor mange ganger terningen viser 1

        for (int i = 0; i < 10; i++) // Jeg kaster terningen 10 ganger
        {
            var diceThrow = GetRandomDice(random); // Jeg kaller metoden for å få et tilfeldig terningkast
            if (diceThrow == 1)
            {
                numberOfThrownNumberOne++; // Jeg øker telleren hvis resultatet er 1
            }
            Console.WriteLine($"You rolled a {diceThrow}"); // Jeg viser resultatet av kastet
        }

        // Jeg viser hvor mange ganger brukeren kastet en ener
        Console.WriteLine($"You rolled a 1 {numberOfThrownNumberOne} times");

        // Jeg spør brukeren om han/hun vil spille igjen
        Console.WriteLine("Do you want to play again? (Y/N)");
        string answer = Console.ReadLine().ToUpper(); // Jeg leser og standardiserer brukerens svar

        if (answer == "N") // Hvis brukeren svarer 'N', avslutter jeg spillet
        {
            Console.WriteLine("Thanks for playing! The program will now exit.");
            break;
        }
        else if (answer != "Y") // Hvis svaret ikke er 'Y', avslutter jeg også
        {
            Console.WriteLine("Invalid input. The program will now exit.");
            break;
        }
    }

    // Jeg venter på at brukeren trykker på en tast før jeg avslutter programmet
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}

// Jeg definerer en metode for å kaste terningen og returnere et tall fra 1 til 6
int GetRandomDice(Random random)
{
    int diceResult = random.Next(1, 7); // Jeg genererer et tall mellom 1 og 6
    return diceResult;
}

// Jeg starter spillet ved å kalle hovedmetoden
ThrowDice();
