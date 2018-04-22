using System.Collections.Generic;

namespace CodingTasks.Arrays
{
    public class Add1ToNumber
    {
        // My implementation
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

            int carry = 1;
            for (var i = A.Count - 1; i >= 0; i--)
            {
                var temp = A[i] + carry;
                carry = temp/10;
                var digit = temp%10;
                A[i] = digit;
            }

            var output = new List<int>();
            if (carry == 1)
            {
                output.Add(1);
            }

            output.AddRange(A);
            return output;
        }

        public List<int> plusOne_(List<int> A)
        {
            List<int> result = new List<int>();
            int carry = 1;
            for (int reverseIndex = A.Count - 1; reverseIndex >= 0; reverseIndex--)
            {
                int sum = A[reverseIndex] + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
            }
            result.Insert(0, carry);
            result.RemoveRange(0, result.FindIndex(n => n != 0));
            return result;
        }
    }
}
