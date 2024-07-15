namespace Alg.solved;

public static class n1436_Destination_City
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new List<List<string>>
                     {
                         new() { "London", "New York" },
                         new() { "New York", "Lima" },
                         new() { "Lima", "Sao Paulo" }
                     }.ToArray(),
                     new List<List<string>>
                     {
                         new() { "B", "C" },
                         new() { "D", "B" },
                         new() { "C", "A" }
                     }.ToArray()
                 })
        {
            var res = DestCity(arr.ToArray());
        }
    }

    private static string DestCity(IList<IList<string>> paths)
    {
        var set = paths.Select(_ => _[0]).ToHashSet();

        return paths.Select(_ => _[1]).First(_ => !set.Contains(_));
    }
}