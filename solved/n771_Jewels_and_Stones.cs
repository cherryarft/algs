namespace Alg.solved;

public static class n771_Jewels_and_Stones
{
    public static void Run()
    {
        foreach (var (str1, str2) in new[]
                 {
                     ("aA", "aAAbbbb"),
                     ("z", "ZZ")
                 })
        {
            var res = NumJewelsInStones(str1, str2);
        }
    }

    static int NumJewelsInStones(string jewels, string stones)
    {
        var set = jewels.ToHashSet();

        return stones.Count(set.Contains);
    }
}