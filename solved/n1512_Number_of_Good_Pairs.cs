namespace Alg.solved;

public static class n1512_Number_of_Good_Pairs
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new int[] { 1, 2, 3, 1, 1, 3 },
                     new int[] { 1, 1, 1, 1 },
                     new int[] { 1, 2, 3, }
                 })
        {
            var res = NumIdenticalPairs(arr);
        }
    }

    private static int NumIdenticalPairs(int[] nums)
    {
        var dic = new Dictionary<int, int>();
        var res = 0;

        foreach (var v in nums)
        {
            if (!dic.TryAdd(v, 1))
            {
                res += dic[v];

                dic[v] += 1;
            }
        }

        return res;
    }
}