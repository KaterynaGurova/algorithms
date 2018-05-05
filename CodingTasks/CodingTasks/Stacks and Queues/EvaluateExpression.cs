using System;
using System.Collections.Generic;

namespace CodingTasks.Stacks_and_Queues
{
    public class EvaluateExpression
    {
        public int evalRPN(List<string> A)
        {
            var i = 0;
            var stack = new Stack<string>();
            while (i < A.Count)
            {
                if (A[i] == "/" || A[i] == "*" || A[i] == "-" || A[i] == "+")
                {
                    var a = int.Parse(stack.Pop());
                    var b = int.Parse(stack.Pop());

                    int result = 0;
                    if (A[i] == "/")
                    {
                        result = b / a;
                    }
                    else if (A[i] == "*")
                    {
                        result = a * b;
                    }
                    else if (A[i] == "-")
                    {
                        result = b - a;
                    }
                    else if (A[i] == "+")
                    {
                        result = a + b;
                    }

                    stack.Push(result.ToString());
                }
                else stack.Push(A[i]);

                i++;
            }

            return int.Parse(stack.Pop());
        }
    }
}
