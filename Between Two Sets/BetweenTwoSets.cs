namespace Between_Two_Sets
{
    public static class BetweenTwoSets
    {
        public static void Solve(List<int> a, List<int> b)
        {
            var smallestNum = b.Min();

            List<int> dividers = new();
            List<int> nonDividers = new();

            foreach (var item in a)
            {
                for (int i = a.Max(); i <= smallestNum; i++)
                {
                    if (i % item == 0)
                    {
                        if (!dividers.Contains(i) && !nonDividers.Contains(i))
                            dividers.Add(i);

                    }
                    else
                    {
                        if (dividers.Contains(i) || !nonDividers.Contains(i))
                        {
                            dividers.Remove(i);
                            nonDividers.Add(i);
                        }
                    }
                }
            }
        }
    }
}

