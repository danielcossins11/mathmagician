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

        public static void calcIntegers(int amount)
        {
            for(int i=0; i< amount; i++)
            {
                Console.WriteLine(i+1 + ", ");
            }
            return;
        }

        public static void calcPrimes(int amount)
        {
            //int[] primes;
            //primes = new int[amount];
            bool result = true;
            int count = 0;
            for(int i=1; i<100; i++)
            {
                result = true;
                for(int j=2; j<i; j++)
                {
                    if(i%j == 0)
                    {
                        result = false;
                        break;
                    }
                }
                //Console.WriteLine(result + " for " + i);
                if(result == true)
                {
                    count++;
                    Console.WriteLine(i);
                }
                if(count >= amount)
                {
                    break;
                }
            }
        }

        public static void calcFibbonacci(int amount)
        {
            int prev1 = 1;
            int prev2 = 0;
            int current = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            for (int i = 1; i <= amount; i++)
            {
                current = prev1 + prev2;
                Console.WriteLine(current);
                prev2 = prev1;
                prev1 = current;
            }
        }

        public static void calcEvens(int amount)
        {
            for(int i=0; i< amount*2; i+=2)
            {
                Console.WriteLine(i);
            }
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
                    calcIntegers(num);
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    calcPrimes(num);
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    calcFibbonacci(num);
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    calcEvens(num);
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