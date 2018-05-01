using System.Collections.Generic;
using System.Text;

namespace CodingTasks
{
    public class ReverseString
    {
        public string reverseString(string A)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < A.Length; i++)
            {
                stack.Push(A[i]);
            }

            var sb = new StringBuilder();
            for (int i = 0; i < A.Length; i++)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }
    }
}
