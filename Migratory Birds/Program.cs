
using System.Linq;

List<int> arr = new List<int>() { 1, 4,4,4,5,3 };

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
