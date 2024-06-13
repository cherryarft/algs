namespace Alg.solved;

public class n643_Maximum_Average_Subarray_I
{
    public static void Run()
    {
        foreach (var (nums, k) in new List<(int[], int)>
                 {
                     ([1, 12, -5, -6, 50, 3], 4),
                     ([5], 1)
                 })
        {
            var res = FindMaxAverage(nums, k);
        }
    }

    static double FindMaxAverage(int[] nums, int k)
    {
        if (nums.Length == 1) return nums[0];

        var sum = 0d;

        for (var right = 0; right < k; ++right)
        {
            sum += nums[right];
        }

        var maxSum = sum;

        for (var right = k; right < nums.Length; ++right)
        {
            sum += nums[right];
            sum -= nums[right - k];

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum / k;
    }
}