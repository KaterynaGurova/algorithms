using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.Arrays
{
    public class Add1ToNumber
    {
        public List<int> plusOne(List<int> input)
        {
            var j = 0;
            var A = new List<int>();
            if (input.Count > 1)
            {
                while (input[j] == 0)
                {
                    j++;
                }
            }
            for (var i = j; i < input.Count; i++)
            {
                A.Add(input[i]);
            }

            var transferable = false;
            for (var i = A.Count - 1; i >= 0; i--)
            {
                if (transferable)
                {
                    if (A[i] < 9)
                    {
                        transferable = false;
                        A[i]++;
                        break;
                    }

                    A[i] = 0;
                }
                else
                {
                    if (A[i] < 9)
                    {
                        A[i]++;
                        break;
                    }

                    A[i] = 0;
                    transferable = true;
                }
            }

            var output = new List<int>();
            if (transferable)
            {
                output.Add(1);
            }

            output.AddRange(A);

            return output;
        }
    }
}
