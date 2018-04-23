using System.Collections.Generic;

namespace CodingTasks.Arrays
{
    public class FindDuplicateInArray
    {
        public int repeatedNumber(List<int> A)
        {
            var existing = new Dictionary<int, int>();
            for (var i = 0; i < A.Count; i++)
            {
                if (!existing.ContainsKey(A[i]))
                {
                    existing[A[i]] = 0;
                }

                existing[A[i]]++;
            }

            var max = 0;
            var maxNumber = -1;
            foreach (var i in existing)
            {
                if (i.Value >= max)
                {
                    max = i.Value;
                    maxNumber = i.Key;
                }
            }

            return maxNumber;
        }
    }
}
