
List<int> ar = new List<int> { 1, 3, 2, 6, 1, 2 };
int n = ar.Count;
int k = 3;
int count = 0;

for (int i = 0; i < n; i++)
{
    for (int a = i + 1; a < n; a++)
    {
        if (((ar[i] + ar[a]) % k == 0))
        {
            count++;
        }
    }
}
    