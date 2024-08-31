namespace Sales_By_Match
{
    public static class SalesByMatch_1
    {
        public static int Solve()
        {

            List<int> ar = new();

            int pairCount = 0;

            Dictionary<int, int> keyValueForSocks = new();

            foreach (var sock in ar.Distinct().Order())
            {
                keyValueForSocks.Add(sock, ar.Where(x => x == sock).Count());
            }


            foreach (var sockInfo in keyValueForSocks)
            {
                //pairCount += sockInfo.Value / 2;

                //Çift Sayı
                if (sockInfo.Value % 2 == 0)
                {
                    pairCount = pairCount + (sockInfo.Value / 2);
                }
                else //Tek Sayı
                {
                    var doubleNumber = (double)sockInfo.Value / 2;
                    var flootNumber = (int)Math.Floor(doubleNumber);
                    pairCount = pairCount + flootNumber;

                }
            }

            return pairCount;
        }
    }
}


 
