using System.Collections.Generic;

namespace CodingTasks
{
    public class RainWaterTrapped
    {
        public int trap(List<int> A)
        {
            var stack = new Stack<int>();

            var currMax = A[0];
            var trapped = 0;
            stack.Push(currMax);
            for (var i = 0; i < A.Count - 1; i++)
            {
                if (A[i + 1] < A[i])
                {
                    stack.Push(A[i + 1]);
                    continue;
                }

                var max = currMax;
                var secondMax = A[i + 1];
                if (A[i + 1] < currMax)
                {
                    secondMax = currMax;
                    max = A[i + 1];
                }

                int count = 0;
                while (stack.Count > 0)
                {
                    var t = stack.Pop();
                    if (t <= max)
                    {
                        trapped += max - t;
                        count++;
                    }
                    else
                    {
                        for (int y = 0; y < count; y++)
                        {
                            stack.Push(max);
                        }

                        currMax = secondMax;
                        break;
                    }
                }
            }

            return trapped;
        }
    }
}
