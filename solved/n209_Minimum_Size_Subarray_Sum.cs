namespace Alg.solved;

public static class n209_Minimum_Size_Subarray_Sum
{
    public static void Run()
    {
        foreach (var (arr, k) in new (int[], int)[]
                 {
                     ([2, 3, 1, 2, 4, 3], 7),
                     ([1, 4, 4], 4),
                     ([1, 1, 1, 1, 1, 1, 1, 1], 11)
                 })
        {
            var res = MinSubArrayLen(k, arr);
        }
    }

    static int MinSubArrayLen(int target, int[] nums)
    {
        var (left, right) = (0, 0);

        var min = nums.Length;
        var sum = 0;

        while (right < nums.Length)
        {
            sum += nums[right];

            while (sum >= target)
            {
                var length = right - left + 1;
                if (length < min)
                {
                    min = length;
                }

                sum -= nums[left++];
            }

            right++;
        }

        return left == 0 ? 0 : min;
    }
}