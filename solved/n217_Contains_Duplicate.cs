namespace Alg.solved;

public static class n217_Contains_Duplicate
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 2, 3, 1 },
                     new[] { 1, 2, 3, 4 },
                     new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
                 })
        {
            var res = ContainsDuplicate(arr);
        }
    }

    private static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        return nums.Any(_ => !set.Add(_));
    }
}