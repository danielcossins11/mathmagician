using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class OddNumbers : NaturalNumbers
    {
        public OddNumbers()
        {
            first = 1;
            increment = 2;
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
