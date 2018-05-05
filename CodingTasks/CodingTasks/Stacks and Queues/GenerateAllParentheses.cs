using System.Collections.Generic;

namespace CodingTasks
{
    public class GenerateAllParentheses
    {
        public int isValid(string A)
        {
            var stack = new Stack<char>();

            for (var i = 0; i < A.Length; i++)
            {
                while (i < A.Length && A[i] != '}' && A[i] != ')' && A[i] != ']')
                {
                    stack.Push(A[i]);
                    i++;
                }

                while (i < A.Length)
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    var c = stack.Pop();
                    if ((c == '[' && A[i] == ']') ||
                    (c == '{' && A[i] == '}') ||
                    (c == '(' && A[i] == ')'))
                    {
                        break;
                    }
                    
                    return 0;
                }

            }

            if (stack.Count > 0)
            {
                return 0;
            }

            return 1;
        }
    }
}
