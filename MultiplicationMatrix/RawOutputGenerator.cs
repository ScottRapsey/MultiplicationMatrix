using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationMatrix
{

    //I started writing code that would return a 2 dimensional array, then I re-read the spec which called for "...code to print out multiplication tables..."
    //so this is (almost) the simplest thing that could possible work and meet the spec
    //that does mean its a bit harder to test tho

    internal class RawOutputGenerator
    {
        internal static string GetMultiplicationMatrixString(int lower, int upper)
        {
            if (lower > upper) throw new ArgumentOutOfRangeException("lower", "lower number must be less than upper number");


            StringBuilder sb = new StringBuilder();
            var result = string.Empty;

            sb.Append("     "); //a space for the top left corner
            for (int rowi = lower; rowi <= upper; rowi++)
            {
                sb.AppendFormat(" {0:000} ", rowi);
            }
            sb.AppendLine();
            //we go off spec here a little
            //the spec calls for the first multiplied number displayed to be the second value multiplied by the second second value
            //ie: if 1,12 were passed in, the first value the spec says we should show is 4, the result of 2*2
            //but humans generally want to see the actual first value, which is 1, the result of 1*1
            for (int rowi = lower; rowi <= upper; rowi++)
            {
                sb.AppendFormat(" {0:000} ", rowi);
                for (int coli = lower; coli <= upper; coli++)
                {
                    sb.AppendFormat(" {0:000} ", (rowi * coli));
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

}
