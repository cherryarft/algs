namespace Alg.solved;

public static class n525_Contiguous_Array
{
   public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [0, 1],
                     [0, 1, 0]
                 })
        {
            var res = FindMaxLength(arr);
        }
    }

    static int FindMaxLength(int[] nums)
    {
        if (nums.Length == 1) return 0;

        var count = 0;
        var ans = 0;

        var dic = new Dictionary<int, int> { [0] = -1 };

        for (var i = 0; i < nums.Length; ++i)
        {
            count += nums[i] == 1 ? 1 : -1;

            if (!dic.TryAdd(count, i))
            {
                ans = int.Max(ans, i - dic[count]);
            }
        }

        return ans;
    }
}