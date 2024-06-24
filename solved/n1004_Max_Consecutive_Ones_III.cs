namespace Alg.solved;

public static class n1004_Max_Consecutive_Ones_III
{
    public static void Run()
    {
        foreach (var (nums, k) in new List<(int[], int)>
                 {
                     ([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2),
                     ([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3)
                 })
        {
            var res = LongestOnes(nums, k);
        }
    }

    static int LongestOnes(int[] nums, int k)
    {
        var flipped = 0;
        var left = 0;
        var maxLength = 0;

        for (var right = 0; right < nums.Length; ++right)
        {
            if (nums[right] == 0)
            {
                flipped++;
            }

            while (flipped > k)
            {
                if (nums[left] == 0)
                {
                    flipped--;
                }

                left++;
            }

            var currentLength = right - left + 1;

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}