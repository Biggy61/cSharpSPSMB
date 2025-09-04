using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz();

            
        }

        public static void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 )
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }

        public static void GuessingNumber()
        {
            Random rnd = new Random();
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            
            int number = rnd.Next(min, max);
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("cislo je mensi");
                }
                else if (guess < number)
                {
                    Console.WriteLine("cislo je vetsi");
                }
                guess = Convert.ToInt32(Console.ReadLine());
            }

            if (guess == number)
            {
                Console.WriteLine("Spravny guess");
            }
            
        }
    }
}