using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jeg spør brukeren om han vil spille
            Console.WriteLine("Vil du spille? (Y/N)");
            string play = Console.ReadLine().ToUpper(); // Jeg leser svaret fra brukeren og gjør det til store bokstaver

            if (play == "Y")
            {
                ifElse test = new ifElse(); // Jeg lager et objekt av klassen ifElse
                test.ReadNumbers(); // Jeg ber brukeren om å skrive inn to tall
                test.EqualNumbers(); // Jeg sjekker om tallene er like

                // Jeg spør brukeren om han vil spille en gang til
                Console.WriteLine("Vil du spille igjen? (Y/N)");
                string answer = Console.ReadLine().ToUpper(); // Jeg leser svaret fra brukeren

                if (answer == "Y")
                {
                    test.ReadNumbers();  // Jeg ber igjen om to tall
                    test.EqualNumbers(); // Jeg sjekker igjen om tallene er like
                    Console.WriteLine("Tester om noen av tallene er 30, eller summen blir 30.");
                    bool isThirty = test.isEqualTo30(test.GetNumber(), test.GetNumber2());
                    Console.WriteLine($"Resultat av isEqualTo30: {isThirty}");
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Takk for spillet! Programmet avsluttes.");
                }
                else
                {
                    Console.WriteLine("Ugyldig valg. Vennligst velg Y eller N. Programmet avsluttes.");
                }
            }
            else if (play == "N")
            {
                Console.WriteLine("Programmet avsluttes.");
            }
            else
            {
                Console.WriteLine("Ugyldig svar! Programmet avsluttes.");
            }

            // Jeg venter på at brukeren trykker på en tast før programmet avsluttes
            Console.WriteLine("Trykk på en tast for å avslutte.");
            Console.ReadKey();
        }
    }

    internal class ifElse
    {
        int number = 5; // Jeg setter en standardverdi på det første tallet
        int number2 = 10; // Jeg setter en standardverdi på det andre tallet
        bool isEqual = false; // Jeg bruker denne for å vite om tallene er like

        // Jeg leser inn tall fra brukeren
        public void ReadNumbers()
        {
            // Jeg ber brukeren skrive inn det første tallet
            Console.WriteLine("Enter first number:");
            string input = Console.ReadLine();

            // Jeg prøver å konvertere input til et heltall
            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"Du skrev inn: {number} som første tall.");
            }
            else
            {
                Console.WriteLine("Ugyldig input for første tall.");
            }

            // Jeg ber brukeren skrive inn det andre tallet
            Console.WriteLine("Enter second number:");
            input = Console.ReadLine();

            // Jeg prøver å konvertere input til et heltall
            if (int.TryParse(input, out number2))
            {
                Console.WriteLine($"Du skrev inn: {number2} som andre tall.");
            }
            else
            {
                Console.WriteLine("Ugyldig input for andre tall.");
            }
        }

        // Jeg sjekker om tallene er like eller ikke
        public void EqualNumbers()
        {
            if (number == number2)
            {
                isEqual = true; // Jeg setter isEqual til true hvis tallene er like
                Console.WriteLine("Tallene er like");
            }
            else
            {
                isEqual = false; // Jeg setter isEqual til false hvis tallene ikke er like
                Console.WriteLine("Tallene er ikke like");
            }

            // Hvis tallene er like, øker jeg det første tallet. Hvis ikke, reduserer jeg det andre.
            if (isEqual)
            {
                number++; // Jeg øker det første tallet med 1
            }
            else
            {
                number2--; // Jeg reduserer det andre tallet med 1
            }

            // Jeg viser resultatet etter jeg har endret på tallene
            Console.WriteLine($"Tall etter økning: {number}, \nTall etter subtraksjon: {number2}");
        }

        // Jeg lager en metode som tar inn to tall og returnerer true hvis en av dem, eller summen når 30
        public bool isEqualTo30(int a, int b)
        {
            if (a == 30 || b == 30 || (a + b) == 30)
            {
                return true; // Jeg returnerer true hvis en av dem er 30 eller summen er 30
            }
            else
            {
                return false; // Jeg returnerer false hvis ingen av dem er 30  d
            }
        }
        // metode for å hente det første tallet
        public int GetNumber()
        {
            return number; // Jeg returnerer det første tallet
        }
        // metode for å hente det andre tallet
        public int GetNumber2()
        {
            return number2; // Jeg returnerer det andre tallet
        }

    }
}
