namespace SubArray_Division
{
    public class SubArrayDivision
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int output = 0;

            for (int i = 0; i < s.Count; i++)
            {
                int contiguosSegmentCount = 0;

                for (int j = 0; j < m; j++)
                {

                    if (i + j == s.Count)
                        break;

                    contiguosSegmentCount += s[i + j];
                }

                if (contiguosSegmentCount == d)
                    output++;
            }

            return output;
        }
    }
}
