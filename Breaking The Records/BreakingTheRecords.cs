namespace Breaking_The_Records
{
    public class BreakingTheRecords
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            int maxVal = scores[0];
            int leastVal = scores[0];
            int maxCount = 0;
            int leastCount = 0;

            foreach (int i in scores.Skip(1))
            {
                if (i > maxVal)
                {
                    maxVal = i;
                    maxCount++;
                }
                else if (i < leastVal)
                {
                    leastVal = i;
                    leastCount++;
                }
            }
            return new List<int> { maxCount, leastCount };

        }
    }
}
