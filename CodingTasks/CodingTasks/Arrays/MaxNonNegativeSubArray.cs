using System;
using System.Collections.Generic;

namespace CodingTasks.Arrays
{
    public class MaxNonNegativeSubArray
    {
        public List<int> maxset(List<int> A)
        {
            long currMax = long.MinValue;
            List<int> currMaxArr = new List<int>();
            var currMaxItemsCount = 0;
            long tempSum = 0;
            var tempArr = new List<int>();
            var tempItemsCount = 0;
            for (var i = 0; i < A.Count; i++)
            {
                if (A[i] < 0)
                {
                    if (tempItemsCount == 0)
                    {
                        continue;
                    }

                    if (tempSum > currMax
                        || (tempSum == currMax && currMaxItemsCount <= tempItemsCount))
                    {
                        currMax = tempSum;
                        currMaxArr = tempArr;
                        currMaxItemsCount = tempItemsCount;
                    }

                    tempItemsCount = 0;
                    tempArr = new List<int>();
                    tempSum = 0;
                }
                else
                {
                    tempSum += A[i];
                    tempArr.Add(A[i]);
                    tempItemsCount++;
                }
            }

            if (tempItemsCount > 0)
            {
                if (tempSum > currMax
                       || (tempSum == currMax && currMaxItemsCount <= tempItemsCount))
                {
                    currMaxArr = tempArr;
                }
            }

            return currMaxArr;
        }
    }
}
