namespace Alg.solved;

public static class n1394_Find_Lucky_Integer_in_an_Array
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 2, 2, 3, 4 },
                     new[] { 1, 2, 2, 3, 3, 3 },
                     new[] { 2, 2, 2, 3, 3 }
                 })
        {
            var res = FindLucky(arr);
        }
    }

    private static int FindLucky(int[] arr)
    {
        var dic = new Dictionary<int, int>();

        foreach (var v in arr)
        {
            if (!dic.TryAdd(v, 1))
            {
                dic[v] += 1;
            }
        }

        var max = -1;
        foreach (var (k, v) in dic)
        {
            if (k == v && max < k)
            {
                max = k;
            }
        }

        return max;
    }
}