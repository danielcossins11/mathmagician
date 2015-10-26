using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 2;
        }

        public static bool CheckIfPrime(int num)
        {
            if (num == 1)
                return false;
            if (num == 2)
                return true;
            if (num == 3)
                return true;

            if (num % 2 == 0)
                return false; //Even number     

            for (int i = 3; i < num/2 + 1; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public override int GetNext(int x)
        {
            int nextNumber = x + 1;
            while (true)
            {
                if (CheckIfPrime(nextNumber))
                {
                    return nextNumber;
                }
                else
                {
                  nextNumber += 1;
                }
            }
        }
    }
}