namespace Alg.solved;

public static class n1426_Counting_Elements
{
    public static void Run()
    {
        foreach (var arr in new int[][]
                 {
                     [1, 2, 3],
                     [1, 1, 3, 3, 5, 5, 7, 7]
                 })
        {
            var res = CountElements(arr);
        }
    }

    static int CountElements(int[] arr)
    {
        var set = new HashSet<int>(arr);

        return arr.Count(x => set.Contains(x + 1));
    }
}