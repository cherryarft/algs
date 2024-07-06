namespace Alg.solved;

public static class n1732_Find_the_Highest_Altitude
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { -5, 1, 5, 0, -7 },
                     new[] { -4, -3, -2, -1, 4, 3, 2 },
                 })
        {
            var res = LargestAltitude(arr);
        }
    }

    static int LargestAltitude(int[] nums)
    {
        var max = nums[0];

        for (var i = 1; i < nums.Length; ++i)
        {
            nums[i] = nums[i - 1] + nums[i];

            if (max < nums[i])
            {
                max = nums[i];
            }
        }

        return max < 0 ? 0 : max;
    }
}