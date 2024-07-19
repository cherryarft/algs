namespace Alg.solved;

public static class n2958_Length_of_Longest_Subarray_With_at_Most_K_Frequency
{
    public static void Run()
    {
        foreach (var (arr, k) in new[]
                 {
                     (new int[] { 1, 2, 2, 1, 3 }, 1),
                     (new int[] { 1, 1, 1, 3 }, 2),
                     (new int[] { 1, 2, 3, 1, 2, 3, 1, 2 }, 2),
                     (new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 1),
                     (new int[] { 5, 5, 5, 5, 5, 5, 5 }, 4)
                 })
        {
            var res = MaxSubarrayLength(arr, k);
        }
    }

    private static int MaxSubarrayLength(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        var (left, right) = (0, 0);
        var max = 0;

        while (right != nums.Length)
        {
            var v = nums[right];

            if (!dic.TryAdd(v, 1))
            {
                dic[v] += 1;
            }

            while (dic[v] > k)
            {
                dic[nums[left]] -= 1;

                left++;
            }

            var cur = right - left + 1;
            if (max < cur)
            {
                max = cur;
            }

            right++;
        }

        return max;
    }
}