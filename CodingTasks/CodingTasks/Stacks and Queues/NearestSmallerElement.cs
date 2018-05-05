using System.Collections.Generic;

namespace CodingTasks
{
    public class NearestSmallerElement
    {
        public List<int> prevSmaller(List<int> A)
        {
            var list = new List<int>();
            var stack = new Stack<int>();

            if (A.Count > 0)
            {
                stack.Push(-1);
                list.Add(-1);
            }
            for (var i = 1; i < A.Count; i++)
            {
                if (A[i] > A[i - 1])
                {
                    list.Add(A[i - 1]);
                    stack.Push(A[i - 1]);
                }
                else
                {
                    int n;
                    do
                    {
                        n = stack.Pop();
                    }
                    while (n >= A[i]);

                    stack.Push(n);
                    list.Add(n);
                }
            }

            return list;
        }
    }
}
