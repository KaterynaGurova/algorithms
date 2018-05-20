using System.Collections.Generic;

namespace CodingTasks.Arrays
{
    public class MaximumUnsortedSubArray
    {
        public List<int> subUnsort(List<int> A)
        {
            var lowerLimit = 0;
            var upperLimit = A.Count - 1;
            for (; lowerLimit < A.Count - 1; lowerLimit++)
            {
                if (A[lowerLimit] > A[lowerLimit + 1]) break;
            }
            for (; upperLimit > 0; upperLimit--)
            {
                if (A[upperLimit] < A[upperLimit - 1]) break;
            }

            if (lowerLimit == A.Count - 1 || upperLimit == 0)
            {
                return new List<int> {-1};
            }

            var min = int.MaxValue;
            var max = int.MinValue;
            for (var i = lowerLimit; i <= upperLimit; i++)
            {
                if (A[i] > max)
                    max = A[i];

                if (A[i] < min)
                    min = A[i];
            }

            var j = upperLimit + 1;
            while (j < A.Count)
            {
                if (A[j] < max)
                {
                    upperLimit++;
                    j++;
                }
                else break;
            }

            var k = lowerLimit - 1;
            while (k >= 0)
            {
                if (A[k] > min)
                {
                    lowerLimit--;
                    k--;
                }
                else break;
            }

            return new List<int> {lowerLimit, upperLimit};
        }
    }
}
