using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTasks.Arrays
{
    public class WaveArray
    {
        public List<int> wave(List<int> A)
        {
            var array = A.ToArray();
            Array.Sort(array);

            for (var i = 0; i < array.Length - 1; i += 2)
            {
                var curr = array[i];
                array[i] = array[1 + i];
                array[i + 1] = curr;
            }

            return array.ToList();
        }
    }
}
