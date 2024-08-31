using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    public static class MigratoryBirds
    {
        //AUTHOR : Yiğitcan Ölmez
        public static int Solve1()
        {
            List<int> arr = new List<int>() { 1, 4, 4, 4, 5, 3 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            var tempArr = new List<int>();

            tempArr.AddRange(arr);


            foreach (var item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    tempArr.Remove(item);
                    dict.Add(item, 0);
                }
                else
                    continue;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == item)
                        dict[item] = dict[item] + 1;
                }
            }


            int maxValue = dict.Values.Max();

            int minKey = dict.Where(kv => kv.Value == maxValue)
                             .Select(kv => kv.Key)
                             .Min();

            return minKey;
        }

        //AUTHOR : Yılmaz Ölmez
        public static int Solve2()
        {
            List<int> arr = new();


            var distinctArr = arr.Distinct().Order();

            Dictionary<int, int> dic = new();

            foreach (var item in distinctArr)
            {
                var countArr = arr.Where(x => x == item).Count();

                dic.Add(item, countArr);
            }

            int maxType = dic.First().Key;
            int maxTypeNumber = dic.First().Value;

            foreach (var item in dic)
            {
                if (item.Value > maxTypeNumber)
                {
                    maxType = item.Key;
                    maxTypeNumber = item.Value;
                }
            }

            return maxType;
        }
    }
}
