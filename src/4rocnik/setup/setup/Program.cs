using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator();
        }

        public static void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
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
            Console.WriteLine("Napis minimum");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napis maximum");
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

        public static void Calculator()
        {
            double result = 0;
            
            Console.WriteLine("Input first number");
            string inputFirstNumber = (Console.ReadLine());
            if (double.TryParse(inputFirstNumber, out double firstNumber))
            {
            }
            else
            {
                Console.WriteLine("Invalid input. That is not a number.");
            }

            Console.WriteLine("Input operator");
            string operatorr = Console.ReadLine();
            Console.WriteLine("Input second number");
            string inputSecondNumber = (Console.ReadLine());
            if (double.TryParse(inputSecondNumber, out double secondNumber))
            {
            }
            else
            {
                Console.WriteLine("Invalid input. That is not a number.");
            }

            switch (operatorr)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "**":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine(result);
        }
    }
}