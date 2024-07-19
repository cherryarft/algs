namespace Alg.solved;

public static class n1695_Maximum_Erasure_Value
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new int[] { 4, 2, 4, 5, 6 },
                     new int[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 }
                 })
        {
            var res = MaximumUniqueSubarray(arr);
        }
    }

    private static int MaximumUniqueSubarray(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        var (res, sum) = (0, 0);
        var (left, right) = (0, 0);

        while (right != nums.Length)
        {
            var v = nums[right];

            sum += v;

            if (!set.Add(v))
            {
                int t;
                do
                {
                    t = nums[left];
                    
                    set.Remove(t);
                    sum -= t;

                    left++;
                } while (t != v);

                set.Add(v);
            }

            if (res < sum)
            {
                res = sum;
            }

            right++;
        }

        return res;
    }
}