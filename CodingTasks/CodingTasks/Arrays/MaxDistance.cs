using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.Arrays
{
    public class MaxDistance
    {
        public int maximumGap(List<int> A)
        {
            var currMaxDist = 0;
            var maxDist = -1;
            if (A.Count == 1)
            {
                return 0;
            }
            A.Sort();


                for (var j = 0; j < A.Count - 1; j++)
                {
                    if (A[j] <= A[j + 1])
                    {
                        currMaxDist++;
                    }
                    else
                    {
                        currMaxDist = 0;
                    }

                    if (currMaxDist > maxDist)
                    {
                        maxDist = currMaxDist;
                    }
                }


            return maxDist;
        }
    }
}
