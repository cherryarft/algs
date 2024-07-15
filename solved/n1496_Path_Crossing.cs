namespace Alg.solved;

public static class n1496_Path_Crossing
{
    public static void Run()
    {
        foreach (var str in new[] { "NES", "NESWW" })
        {
            var res = IsPathCrossing(str);
        }
    }

    private static bool IsPathCrossing(string path)
    {
        var set = new HashSet<int>();

        var (f, s) = (10_000, 10_000);
        set.Add(ToPoint(f, s));

        foreach (var c in path.ToArray())
        {
            switch (c)
            {
                case 'N':
                    f++;
                    break;
                case 'S':
                    f--;
                    break;
                case 'E':
                    s++;
                    break;
                case 'W':
                    s--;
                    break;
            }

            if (!set.Add(ToPoint(f, s)))
            {
                return true;
            }
        }

        return false;

        static int ToPoint(int f, int s) => f + s * 10_000;
    }
}