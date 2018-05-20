using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.Arrays
{
    public class NobleInteger
    {
        public int solve(List<int> A)
        {
            var array = A.ToArray();
            Array.Sort(array);

            for (var i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1 && array[i] == array[i + 1])
                {
                    continue;
                }

                if (array[i] == array.Length - i - 1)
                {
                    return 1;
                }
            }

            return -1;
        }
    }
}
