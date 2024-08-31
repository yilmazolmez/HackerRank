namespace Bill_Division
{
    public static class BillDivision_2
    {  //AUTHOR : Yılmaz Ölmez
        public static void Solve()
        {
            var bill = new List<int> { 3, 10, 2, 9 };
            int k = 1;
            int b = 7;

            int doesntEat = bill[k];
            int totalCostSharedItem = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                {
                    continue;
                }

                totalCostSharedItem += bill[i];
            }

            int halfActual = totalCostSharedItem / 2;
            var result = b - halfActual;

            if (b == halfActual)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
