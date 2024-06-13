namespace Alg.solved;

public static class n1413_Minimum_Value_to_Get_Positive_Step_by_Step_Sum
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [-3, 2, -3, 4, 2],
                     [1, 2],
                     [1, -2, -3]
                 })
        {
            var res = MinStartValue(arr);
        }
    }

    static int MinStartValue(int[] nums)
    {
        var min = nums[0];

        for (var i = 1; i < nums.Length; ++i)
        {
            nums[i] = nums[i] + nums[i - 1];

            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return min < 0 ? -min + 1 : 1;
    }
}