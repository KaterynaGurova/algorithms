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
            if (A.Count == 1)
            {
                return 0;
            }

            var map = new Map[A.Count];
            for (var i = 0; i < A.Count; i++)
            {
                map[i] = new Map {Index = i, Value = A[i]};
            }
            Array.Sort(map, (x, e) =>
            {
                if (x.Value > e.Value) return 1;
                if (x.Value == e.Value) return 0;
                return -1;
            });

            var max = int.MinValue;
            var maxs = new int[A.Count];
            for (var i = A.Count - 1; i >= 0; i--)
            {
                if (map[i].Index > max)
                {
                    max = map[i].Index;
                }

                maxs[i] = max;
            }

            var maxp = 0;
            for (int y = 0; y < A.Count; y++)
            {
                if (maxs[y] > maxp)
                    maxp = maxs[y];
            }


            //var maxmax = 0;
            //for (var j = 0; j < A.Count; j++)
            //{
            //    for (var k = j + 1; k < A.Count; k++)
            //    {
            //        if (map[k].Index - map[j].Index > maxmax)
            //        {
            //            maxmax = Math.Abs(map[j].Index - map[k].Index);
            //        }
            //    }
            //}

           return maxp;
        }

        private class Map
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }

        public int maximumGap_NotEfficient(List<int> A)
        {
            var maxDist = 0;
            if (A.Count == 1)
            {
                return 0;
            }

            for (var i = 0; i < A.Count; i++)
            {
                for (var j = A.Count - 1; j > i; j--)
                {
                    if (A[i] <= A[j])
                    {
                        if (j - i > maxDist)
                        {
                            maxDist = j - i;
                        }

                        break;
                    }
                }
            }

            return maxDist;
        }
    }
}
