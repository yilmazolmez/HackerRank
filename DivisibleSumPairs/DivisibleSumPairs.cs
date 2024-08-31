namespace DivisibleSumPair
{
    public static class DivisibleSumPairs
    {
        //AUTHOR : Yiğitcan Ölmez
        public static void Solve()
        {
            List<int> ar = new List<int> { 5, 9, 10, 7, 4 };
            int n = 5;
            int k = 2;


            int output = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = i; j > 0; j--)
                {
                    int tempSum = 0;

                    tempSum += (ar[i] + ar[j]);

                    if (tempSum % 3 == 0)
                        output++;
                }
            }

        }

    }
}
