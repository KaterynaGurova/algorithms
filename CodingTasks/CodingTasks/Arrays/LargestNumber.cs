using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.Arrays
{
    public class LargestNumber
    {
        public string largestNumber(List<int> A)
        {
            var arr = new List<char[]>();
            var ptrs = new List<int>();
            foreach (var a in A)
            {
                arr.Add(a.ToString().ToCharArray());
                ptrs.Add(0);
            }

            //Max array count
            var maxArrCount = int.MinValue;
            for (var i = 0; i < arr.Count; i++)
            {
                if (arr[i].Count() > maxArrCount)
                {
                    maxArrCount = arr[i].Count();
                }
            }

            // Sorting


            while (ptrs.Count > 0)
            {
                var max = int.MinValue;
                var prevPointer = -1;
                for (var j = 0; j < arr.Count; j++)
                {
                    if (ptrs[j] >= arr[j].Count())
                    {
                        //zakonchilsya
                    }

                    if (arr[j][ptrs[j]] > max)
                    {
                        max = arr[ptrs[j]][i];
                        indexX = ptrs[j];
                    }
                    else if (arr[j][ptrs[j]] == max)
                    {

                    }

                    ptrs[j]++;
                }
            }






            var tempMaxIndex = -1;
            for (var i = 0; i < maxArrCount; i++)
            {
                var max = int.MinValue;
                var indexX = -1;
                var indexY = -1;
                for (var j = 0; j < arr.Count; j++)
                {
                    if (arr[ptrs[j]].Count() < i)
                    {
                        if (arr[ptrs[j]][i] > max)
                        {
                            max = arr[ptrs[j]][i];
                            indexX = ptrs[j];
                        }
                        else if (arr[j][i] == max)
                        {
                            
                        }
                    }
                }

                tempMaxIndex = index;
            }


            //var sorted = new List<char[]>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    var max = int.MinValue;
            //    for (int j = 0; j < arr[i].Count(); j++)
            //    {
            //        if (arr[i][j] > max && j == arr[i].Count() - 1)
            //        {
            //            max = arr[i][j];
            //        }
            //    }
            //}
        }
    }
}
