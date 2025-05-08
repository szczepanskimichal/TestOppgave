
namespace Test
{


    internal class ifElse
    {
        int number = 5;
        int number2 = 10;
        bool isEqual = false;

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
            }
            else
            {
                number2--;
            }
        }
    }
}