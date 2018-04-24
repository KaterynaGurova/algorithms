using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTasks.Arrays
{
    public class LargestNumber
    {
        public string largestNumber(List<int> A)
        {
            var zeroes = true;
            for (var i = 0; i < A.Count; i++)
            {
                if (A[i] != 0)
                {
                    zeroes = false;
                }
            }
            if (zeroes)
                return "0";

            var number = new StringBuilder();
            while (A.Count > 0)
            {
                var e = A[0];
                for (var i = 0; i < A.Count; i++)
                {
                    var number1 = e.ToString();
                    var number2 = A[i].ToString();
                    var a = Convert.ToInt64(number1 + number2);
                    var b = Convert.ToInt64(number2 + number1);

                    if (b > a)
                    {
                        e = A[i];
                    }
                }

                number.Append(e.ToString());
                A.Remove(e);
            }

            return number.ToString();
        }




        //public string largestNumber(List<int> A)
        //{
        //    var arr = new List<char[]>();
        //    var ptrs = new List<int>();
        //    foreach (var a in A)
        //    {
        //        arr.Add(a.ToString().ToCharArray());
        //        ptrs.Add(0);
        //    }

        //    var result = new List<string>();
        //    while (arr.Count > 0)
        //    {
        //        var maxs = new List<int>();
        //        var currMax = int.MinValue;
        //        var wholeNums = new List<int>();
        //        for (var i = 0; i < arr.Count; i++)
        //        {
        //            if (arr[i].Count() <= ptrs[i])
        //            {
        //                wholeNums.Add(i);
        //            }
        //            if (arr[i].Count() > ptrs[i] && (int)arr[i][ptrs[i]] > currMax)
        //            {
        //                currMax = (int)arr[i][ptrs[i]];
        //            }
        //        }
        //        for (var i = 0; i < arr.Count; i++)
        //        {
        //            if (arr[i].Count() > ptrs[i] && arr[i][ptrs[i]] == currMax)
        //            {
        //                maxs.Add(i);
        //            }
        //        }

        //        if (maxs.Count == wholeNums.Count)
        //        {
        //            for (int i = 0; i < wholeNums.Count; i++)
        //            {
        //                var index = maxs.First();
        //                result.Add(arr[index].ToString());
        //                arr.RemoveAt(index);
        //                ptrs.RemoveAt(index);
        //            }
        //            wholeNums = new List<int>();
        //        }

        //        if (maxs.Count == 1)
        //        {
        //            var index = maxs.First();
        //            result.Add(arr[index].ToString());
        //            arr.RemoveAt(index);
        //            ptrs.RemoveAt(index);
        //            continue;
        //        }

        //        if (maxs.Count > 1)
        //        {
        //            for (var i = 0; i < arr.Count; i++)
        //            {
        //                if (maxs.Any(x => x == i)) ptrs[i]++;
        //                else ptrs[i] = 0;
        //            }
        //        }
        //    }

        //    return string.Concat(result);
        //}
    }
}
