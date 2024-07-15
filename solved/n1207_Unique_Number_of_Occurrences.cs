namespace Alg.solved;

public static class n1207_Unique_Number_of_Occurrences
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 2, 2, 1, 1, 3 },
                     new[] { 1, 2 },
                     new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }
                 })
        {
            var res = UniqueOccurrences(arr);
        }
    }

    private static bool UniqueOccurrences(int[] arr)
    {
        var dic = new Dictionary<int, int>();

        foreach (var key in arr)
        {
            if (!dic.TryAdd(key, 1))
            {
                dic[key] += 1;
            }
        }

        var set = new HashSet<int>();

        foreach (var (_, v) in dic)
        {
            if (!set.Add(v)) return false;
        }

        return true;
    }
}