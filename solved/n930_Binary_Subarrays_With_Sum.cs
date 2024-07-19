namespace Alg.solved;

public static class n930_Binary_Subarrays_With_Sum
{
    public static void Run()
    {
        foreach (var (arr, g) in new[]
                 {
                     (new int[] { 1, 0, 1, 0, 1 }, 2),
                     (new int[] { 0, 0, 0, 0, 0 }, 0)
                 })
        {
            var res1 = V1.NumSubarraysWithSum(arr, g);
            var res2 = V2.NumSubarraysWithSum(arr, g);
        }
    }

    private static class V1
    {
        public static int NumSubarraysWithSum(int[] nums, int goal)
        {
            var dic = new Dictionary<int, int> { [0] = 1 };
            var (res, sum) = (0, 0);

            foreach (var v in nums)
            {
                sum += v;

                if (dic.ContainsKey(sum - goal))
                {
                    res += dic[sum - goal];
                }

                if (!dic.TryAdd(sum, 1))
                {
                    dic[sum] += 1;
                }
            }

            return res;
        }
    }

    private static class V2
    {
        public static int NumSubarraysWithSum(int[] nums, int goal)
        {
            var (res, sum, z) = (0, 0, 0);
            var (left, right) = (0, 0);

            while (right != nums.Length)
            {
                var v = nums[right];

                sum += v;

                while (left < right && (nums[left] == 0 || sum > goal))
                {
                    if (nums[left] == 0)
                    {
                        z++;
                    }
                    else
                    {
                        z = 0;
                    }

                    sum -= nums[left];

                    left++;
                }

                if (sum == goal)
                {
                    res += 1 + z;
                }

                right++;
            }

            return res;
        }
    }
}