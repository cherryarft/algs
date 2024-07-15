namespace Alg.solved;

public static class n1748_Sum_of_Unique_Elements
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 2, 3, 2 },
                     new[] { 1, 1, 1, 1, 1 },
                     new[] { 1, 2, 3, 4, 5 }
                 })
        {
            var res = SumOfUnique(arr);
        }
    }

    private static int SumOfUnique(int[] nums)
    {
        var dic = new Dictionary<int, int>();
        var sum = 0;

        foreach (var key in nums)
        {
            if (dic.TryAdd(key, 1))
            {
                sum += key;
            }
            else
            {
                if (dic[key] == 1)
                {
                    sum -= key;
                }

                dic[key] = 2;
            }
        }

        return sum;
    }
}