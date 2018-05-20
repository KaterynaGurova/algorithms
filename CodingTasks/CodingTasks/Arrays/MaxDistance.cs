using System;
using System.Collections.Generic;

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
            //we are essentially looking at max index[j] for all j > i.
            for (var i = A.Count - 1; i >= 0; i--)
            {
                if (map[i].Index > max)
                {
                    max = map[i].Index;
                }

                maxs[i] = max;
            }

            var maxDistance = 0;
            for (var y = 0; y < A.Count; y++)
            {
                var d = maxs[y] - map[y].Index;
                if (d > maxDistance)
                    maxDistance = d;
            }

            return maxDistance;
        }

        private class Map
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }

        private int maximumGap_NotEfficient(List<int> A)
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
