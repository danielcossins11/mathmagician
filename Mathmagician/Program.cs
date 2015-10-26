using System;
using Mathmagician;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        public static string getValidstring()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "natural numbers" || input.ToLower() == "even numbers" || input.ToLower() == "odd numbers" || input.ToLower() == "fibonacci numbers" || input.ToLower() == "prime numbers")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return input;
        }

        public static int getValidInt()
        {
            int inputInt;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputInt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return inputInt;
        }

        static void Main(string[] args)
        {
            string prompt = "> ";
            Console.WriteLine(@"What do you want me to do?
Natural Numers
Even Numbers
Odd Numbers
Fibonacci Numbers
Prime Numbers");
            Console.Write(prompt);
            string input = getValidstring();
            Console.WriteLine("How many?");
            int inputInt = getValidInt();
            //if (response.ToLower() == "natural numbers")
            //{
            //    Console.WriteLine("How many?");
            //    Console.Write(prompt);
            //    string response_length = Console.ReadLine();
            //    int length;
            //    bool parsed = int.TryParse(response_length, out length);
            //    if (parsed)
            //    {
            //        NaturalNumbers nats = new NaturalNumbers();
            //        Console.WriteLine(nats.ToString(nats.GetSequence(length)));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Whoops!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Nope! Do better next time.");
            //}
            switch (input.ToLower())
            {
                case "natural numbers":
                    NaturalNumbers nats = new NaturalNumbers();
                    Console.WriteLine(nats.ToString(nats.GetSequence(inputInt)));
                    break;
                case "even numbers":
                    EvenNumbers evens = new EvenNumbers();
                    Console.WriteLine(evens.ToString(evens.GetSequence(inputInt)));
                    break;
                case "odd numbers":
                    OddNumbers odds = new OddNumbers();
                    Console.WriteLine(odds.ToString(odds.GetSequence(inputInt)));
                    break;
                case "fibonacci numbers":
                    FibonacciNumbers fibs = new FibonacciNumbers();
                    Console.WriteLine(fibs.ToString(fibs.GetSequence(inputInt)));
                    break;
                case "prime numbers":
                    PrimeNumbers primes = new PrimeNumbers();
                    Console.WriteLine(primes.ToString(primes.GetSequence(inputInt)));
                    break;
                default:
                    Console.WriteLine("Whoops!");
                    break;
            }
            Console.WriteLine("Press any key to finish . . .");
            Console.ReadKey();
        }
    }
}