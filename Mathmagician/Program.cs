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
                    if (inputInt == 1 || inputInt == 2 || inputInt == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
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
            Console.WriteLine("What would you like for me to do?");
            int input = getValidInput();






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
                default:
                    Console.WriteLine("Default case");
                    break;
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
