using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        public static int getValidInput()
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
            Console.WriteLine(@"What would you like for me to do?
1. Integers
2. Primes
3. Fibonacci
4. even
5. odd");
            int input = getValidInput();
            while(input < 1 || input > 5)
            {
                Console.WriteLine("Invalid input");
                input = getValidInput();
            }

            Console.WriteLine("how many should I print?");
            int num = getValidInput();


            

            switch (input)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}