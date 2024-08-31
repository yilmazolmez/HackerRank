namespace Sales_By_Match
{
    public static class SalesByMatch_2
    {
        public static int Solve()
        {
            List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Dictionary<int, int> dict = new Dictionary<int, int>();


            for (int i = 0; i < ar.Count; i++)
            {
                if (!dict.ContainsKey(ar[i]))
                {
                    var count = ar.Where(x => x == ar[i]).ToList().Count;

                    dict.Add(ar[i], count);
                }
            }
            var dictSum = dict.Select(y => y.Value / 2).ToList();

            return dictSum.Sum();
        }
    }
}