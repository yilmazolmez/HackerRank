namespace Bill_Division
{
    public static class BillDivision
    {
        //AUTHOR : Yiğitcan Ölmez
        public static void Solve1()
        {
            int b = 7;
            int k = 1;
            var bill = new List<int> { 3, 10, 2, 9 };

            var billTotal = bill.Sum();

            if ((billTotal / 2) == bill[k])
                Console.WriteLine("Bon Appetit");
            else if (((billTotal - bill[k]) / 2) == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(bill[k] / 2);
        }

        //AUTHOR : Yılmaz Ölmez
        public static void Solve2()
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
