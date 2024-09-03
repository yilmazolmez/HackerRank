namespace Counting_Valleys;

public class CountingValleys
{
    public static int CountingValley(int steps, string path)
    {
        int valleyCount = 0;
        int floor = 0;

        foreach (var step in path)
        {
            floor = step == 'U' ? floor + 1 : floor - 1;

            if (floor == 0 && step == 'U')
                valleyCount++;
        }

        return valleyCount;




    }
}
