using System;

void ThrowDice()
{
    
    Random random = new Random(); // Przeniesiono tutaj
    Console.WriteLine("welcome adsondsao");
    int numberOfThrownNumberOne = 0;
    for (int i = 0; i < 10; i++)
    {
        var diceThrow = GetRandomDice(random);
        if (diceThrow == 1) {
         numberOfThrownNumberOne++;
        }
        Console.WriteLine($"You rolled a {diceThrow}");
    }
    Console.WriteLine($"You rolled a 1 {numberOfThrownNumberOne} times");
}
ThrowDice();
int GetRandomDice(Random random)
{
    int diceResult = random.Next(1, 7);
    return diceResult;
}


