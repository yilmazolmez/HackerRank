namespace Drawing_Book
{
    public class DrawingBook2
    {
        public static int PageCount(int n, int p)
        {
            int fromFront = p / 2;

            int fromBack = (n / 2) - (p / 2);

            return Math.Min(fromFront, fromBack);

        }
    }
}
