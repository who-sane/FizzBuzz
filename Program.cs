using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
        // Multiple of 3 = Fizz
        // Multiple of 5 = Buzz
        // Multiple of both = FizzBuzz


        // Using a loop statement, print numbers 1 to 100

        for (int o = 0; o < 100; o++)
        {
         // If the number is equal to a multiple (mod func) of 15 ( 5 x 3 ) then output FizzBuzz
            if (o % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
        // If the number is equal to a multiple (mod func) of 5 then output Buzz
            else if (o % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // If the number is equal to a multiple (mod func) of 3 then output Fizz
            else if (o % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(o);
            }
            
        }

        }
    }
}
