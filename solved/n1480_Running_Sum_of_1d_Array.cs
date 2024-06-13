namespace Alg.solved;

public static class n1480_Running_Sum_of_1d_Array
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [1, 2, 3, 4],
                     [1, 1, 1, 1, 1],
                     [3, 1, 2, 10, 1]
                 })
        {
            var res = RunningSum(arr);
        }
    }

    static int[] RunningSum(int[] nums)
    {
        for (var i = 1; i < nums.Length; ++i)
        {
            nums[i] = nums[i] + nums[i - 1];
        }

        return nums;
    }
}