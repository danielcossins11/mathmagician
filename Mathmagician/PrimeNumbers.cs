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

        public override int GetNext(int x)
        {
            int nextPrime =0;
            for(int i=x+2; i<1000; i++)
            {
                if (i % 2 != 0)
                {
                    for(int j=2; j<=i/2 + 1; i++)
                    {
                        if (i%j == 0)
                        {
                            nextPrime = i;
                        }
                    }
                }
            }
            //for(int i=x; i<1000; i++)
            //{
            //    if(i.isPrime)
            //}
            return nextPrime;
        }
    }
}
