using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumbers : NaturalNumbers
    {
        public EvenNumbers()
        {
            first = 2;
        }

        public override int GetNext(int x)
        {
            //return x + 2;
            return base.GetNext(x) + 1;
        }

        public override int[] GetSequence(int length)
        {
            //int[] output = new int[length];
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }
    }
}
