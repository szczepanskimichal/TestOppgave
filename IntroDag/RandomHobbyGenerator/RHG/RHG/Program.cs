using System;

class RandomHobbyGenerator
{
    static void Main()
    {
        Random rand = new Random();
        var randomNumber = rand.Next(0, 10);

        if (randomNumber == 0)
        {
            Console.WriteLine("Your random hobby is: Reading");
        }
        else if (randomNumber == 1)
        {
            Console.WriteLine("Your random hobby is: Painting");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine("Your random hobby is: Gardening");
        }
        else if (randomNumber == 3)
        {
            Console.WriteLine("Your random hobby is: Cooking");
        }
        else if (randomNumber == 4)
        {
            Console.WriteLine("Your random hobby is: Hiking");
        }
        else if (randomNumber == 5)
        {
            Console.WriteLine("Your random hobby is: Photography");
        }
        else if (randomNumber == 6)
        {
            Console.WriteLine("Your random hobby is: Writing");
        }
        else if (randomNumber == 7)
        {
            Console.WriteLine("Your random hobby is: Knitting");
        }
        else if (randomNumber == 8)
        {
            Console.WriteLine("Your random hobby is: Playing a musical instrument");
        }
        else
        {
            Console.WriteLine("Your random hobby is: Traveling");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
