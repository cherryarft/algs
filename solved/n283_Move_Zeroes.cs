namespace Alg.solved;

public static class n283_Move_Zeroes
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [0, 1, 0, 3, 12],
                     [0]
                 })
        {
            MoveZeroes(arr);
        }
    }

    static void MoveZeroes(int[] nums)
    {
        var (n, z) = (0, 0);

        while (n < nums.Length)
        {
            if (nums[n] != 0)
            {
                (nums[z], nums[n]) = (nums[n], nums[z]);

                z++;
            }

            n++;
        }
    }
}