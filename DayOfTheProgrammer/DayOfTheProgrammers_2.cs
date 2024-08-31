namespace DayOfTheProgrammers
{
    public static class DayOfTheProgrammers_2
    {
        //AUTHOR : Yılmaz Ölmez

        public static string Solve()
        {
            var year = 2100;
            int maxSumDay = 256;
            int sumDay = 1;

            var testValue = 0;

            if (year > 2000)
            {
                testValue = (year % 400 == 0)
            || (year % 4 == 0 && year % 100 != 0) ? 29 : 28;
            }
            else if (year == 1918)
            {
                testValue = 15;
            }
            else
            {
                testValue = year % 4 == 0 ? 29 : 28;
            }

            Dictionary<int, int> months = new Dictionary<int, int>
            {
                { 1, 31 },
                { 2, testValue },
                { 3, 31 },
                { 4, 30 },
                { 5, 31 },
                { 6, 30 },
                { 7, 31 },
                { 8, 31 },
                { 9, 30 },
                { 10, 31 },
                { 11, 30 },
                { 12, 31 }
            };

            int monthValue = months.First().Key;

            foreach (var item in months)
            {
                if ((sumDay + item.Value) > maxSumDay)
                    break;

                sumDay += item.Value;
                monthValue = item.Key;
            }

            var result = maxSumDay - sumDay;

            result = result + 1;
            monthValue = monthValue + 1;

            var stringResult = result < 10 ? "0" + result.ToString() : result.ToString();
            var stringMonthValue = monthValue < 10 ? "0" + monthValue.ToString() : monthValue.ToString();

            string aa = $"{stringResult}.{stringMonthValue}.{year}";

            return aa;
        }
    }
}
