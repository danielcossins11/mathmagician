using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        private int[] listOfPrimes;
        private int upperBound;
        public PrimeNumbers()
        {
            listOfPrimes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
            first = 2;
            upperBound = 200;
        }

        public bool isPrime(int x)
        {
            bool result = false;
            bool foundComposite = false;
            int i = 3;
            while (i < x)
            {
                if(x % i == 0)
                {
                    //throw new ArgumentException();
                    foundComposite = true;
                    break;
                }
                i += 2;
            }
            if (!foundComposite)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public override int GetNext(int x)
        {
            if(x < 100)
            {
              return listOfPrimes[FindIndex(x) + 1];
            }
            else if(x > upperBound)
            {
                throw new ArgumentException("You've exceeded our capabilities. Pay more money for more primes.");
            } else if (!isPrime(x))
            {
                throw new ArgumentException();
            }
            else
            {
                int candidate = x + 2;
                while (!isPrime(candidate))
                {
                    candidate += 2;
                }
                return candidate;


                //int candidate = x + 2;
                //while (true)
                //{
                //    for (int i = 3; i < candidate; i+=2)
                //    {
                //        if(candidate % i == 0) {
                //            //throw new ArgumentException();
                //            break;
                //        }
                //    }
                //    candidate += 2;
                //}

                //for (int i = 3; i < x; i+=2)
                //{
                //    if(x % i == 0) {
                //        throw new ArgumentException();
                //    }
                //}
                //return x;

            }
        }

        public int FindIndex(int element)
        {
            if (listOfPrimes.Contains(element))
            {
                for(int i=0; i<listOfPrimes.Length; i++)
                {
                    if(listOfPrimes[i] == element)
                    {
                        return i;
                    }
                }
                throw new ArgumentException();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        //public static bool CheckIfPrime(int num)
        //{
        //    if (num == 1)
        //        return false;
        //    if (num == 2)
        //        return true;
        //    if (num == 3)
        //        return true;

        //    if (num % 2 == 0)
        //        return false; //Even number     

        //    for (int i = 3; i < num/2 + 1; i += 2)
        //    {
        //        if (num % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        //public override int GetNext(int x)
        //{
        //    int nextNumber = x + 1;
        //    while (true)
        //    {
        //        if (CheckIfPrime(nextNumber))
        //        {
        //            return nextNumber;
        //        }
        //        else
        //        {
        //          nextNumber += 1;
        //        }
        //    }
        //}
    }
}