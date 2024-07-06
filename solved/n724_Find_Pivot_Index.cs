namespace Alg.solved;

public static class n724_Find_Pivot_Index
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 7, 3, 6, 5, 6 },
                     new[] { 1, 2, 3 },
                     new[] { 2, 1, -1 },
                 })
        {
            var res = PivotIndex(arr);
        }
    }

    static int PivotIndex(int[] nums)
    {
        var (left, total) = (0, nums.Sum());

        for (var i = 0; i < nums.Length; ++i)
        {
            if (left == total - left - nums[i])
            {
                return i;
            }

            left += nums[i];
        }

        return -1;
    }
}