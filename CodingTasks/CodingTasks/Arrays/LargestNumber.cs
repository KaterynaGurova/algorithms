using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTasks.Arrays
{
    public class MyComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            var number1 = x.ToString();
            var number2 = y.ToString();
            var a = long.Parse(number1 + number2);
            var b = long.Parse(number2 + number1);

            if (a == b) return 0;

            return b > a ? 1 : -1;
        }
    }

    public class LargestNumber
    {
        public string largestNumber(List<int> A)
        {
            var zeroes = true;
            foreach (var a in A)
            {
                if (a != 0)
                {
                    zeroes = false;
                }
            }
            if (zeroes) return "0";

            var arr = A.ToArray();
            Array.Sort(arr, new MyComparer());

            var number = new StringBuilder();
            foreach (var a in arr)
            {
                number.Append(a);
            }

            return number.ToString();
        }
    }
}
