namespace Alg.solved;

public static class n3005_Count_Elements_With_Maximum_Frequency
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 2, 2, 3, 1, 4 },
                     new[] { 1, 2, 3, 4, 5 }
                 })
        {
            var res = MaxFrequencyElements(arr);
        }
    }

    private static int MaxFrequencyElements(int[] nums)
    {
        var dic = new Dictionary<int, int>();

        foreach (var key in nums)
        {
            if (!dic.TryAdd(key, 1))
            {
                dic[key] += 1;
            }
        }

        var maxFrequency = 1;
        var res = 0;

        foreach (var frequency in dic.Values)
        {
            if (maxFrequency < frequency)
            {
                maxFrequency = frequency;

                res = frequency;

                continue;
            }

            if (maxFrequency != frequency)
            {
                continue;
            }

            res += frequency;
        }

        return res;
    }
}