namespace Alg.solved;

public class n268_Missing_Number
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [3, 0, 1],
                     [0, 1],
                     [9, 6, 4, 2, 3, 5, 7, 0, 1]
                 })
        {
            var res = MissingNumber(arr);
        }
    }

    static int MissingNumber(int[] nums)
    {
        var total = 0;
        for (var i = 1; i < nums.Length + 1; ++i)
        {
            total += i;
        }

        return total - nums.Sum();
    }
}