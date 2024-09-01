namespace Drawing_Book
{
    public class DrawingBook
    {
        public static int PageCount(int n, int p)
        {
            if (p == 1)
                return 0;
            else if (n - p == 1 && p % 2 != 0)
                return 1;
            else if (n - p == 0)
                return 0;

            var fromFront = p / 2;

            var fromBack = (n - p) / 2;

            return fromFront < fromBack ? fromFront : fromBack;
        }
   

    }
}
