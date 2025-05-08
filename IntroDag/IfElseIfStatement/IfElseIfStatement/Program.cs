using System;
namespace Test
{
   internal class Program
    {
        static void Main(string[] args)
        {
            ifElse test = new ifElse();
            test.ReadNumbers(); //tall fra brukeren
            test.EqualNumbers(); // talene er like eller ikke
        }
    }


    internal class ifElse
    {
        int number = 5; // initialiserer variabelen, default er 5
        int number2 = 10;
        bool isEqual = false;

        public void ReadNumbers()
        {
            {
                //Laster inn det første tallet
                Console.WriteLine("Enter first number:");
                number = Convert.ToInt32(Console.ReadLine()); // jeg lagrer numer fra brukeren
                //Laster inn det andre tallet
                Console.WriteLine("Enter second number:");
                number2 = Convert.ToInt32(Console.ReadLine()); // jeg lagrer numer fra brukeren
            }
        
            
        }
        

        

        public void EqualNumbers()
        {
            if (number == number2)
            {
                isEqual = true;
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Numbers are not equal");
            }

            if (isEqual)
            {
                number++;
               // Console.WriteLine($"Tall etter multiplikasjon {number}");
            }
            else
            {
                number2--;
               // Console.WriteLine($"Tall etter subtraksjon {number2}");
            }
            Console.WriteLine($"Tall etter multiplikasjon: {number}, \n Tall etter subtraksjon: {number2}");
        }
    }
}