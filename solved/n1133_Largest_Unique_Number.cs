using System.Runtime.InteropServices;

namespace Alg.solved;

public class n1133_Largest_Unique_Number
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [5, 7, 3, 9, 4, 9, 8, 3, 1],
                     [9, 9, 8, 8]
                 })
        {
            var res = LargestUniqueNumber(arr);
        }
    }

    static int LargestUniqueNumber(int[] nums)
    {
        var dic = new Dictionary<int, bool>(nums.Length);

        foreach (var value in nums)
        {
            ref var seemed = ref CollectionsMarshal.GetValueRefOrAddDefault(dic, value, out var exists);

            seemed = exists;
        }

        var max = -1;
        foreach (var (value, seemed) in dic)
        {
            if (!seemed && max < value)
            {
                max = value;
            }
        }

        return max;
    }
}