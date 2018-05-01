using System.Collections.Generic;

namespace CodingTasks
{
    public class RedundantBraces
    {
        public int braces(string A)
        {
            var stack = new Stack<char>();
            var i = 0;
            while (i < A.Length)
            {
                while (i < A.Length && A[i] != ')')
                {
                    stack.Push(A[i]);
                    i++;
                }
                if (i >= A.Length) return 0;
                i++;
                var j = 0;
                while (stack.Count > 0)
                {
                    var item = stack.Pop();
                    if (item == '(')
                        break;
                    j++;
                }

                if (j < 3) return 1;

                stack.Push('a');
            }

            return 0;
        }
    }
}
