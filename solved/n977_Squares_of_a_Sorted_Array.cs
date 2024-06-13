namespace Alg.solved;

public static class n977_Squares_of_a_Sorted_Array
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [-4, -1, 0, 3, 10],
                     [-7, -3, 2, 3, 11]
                 })
        {
            var res = SortedSquares(arr);
        }
    }

    static int[] SortedSquares(int[] nums)
    {
        var (left, right) = (0, nums.Length - 1);
        var res = new int[nums.Length];
        var i = res.Length - 1;

        while (left <= right)
        {
            var f = nums[right] * nums[right];
            var s = nums[left] * nums[left];

            if (f > s)
            {
                res[i--] = f;
                right--;
            }
            else
            {
                res[i--] = s;
                left++;
            }
        }

        return res;
    }
}