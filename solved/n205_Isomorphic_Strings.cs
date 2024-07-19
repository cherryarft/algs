namespace Alg.solved;

public static class n205_Isomorphic_Strings
{
    public static void Run()
    {
        foreach (var (s1, s2) in new[]
                 {
                     ("egg", "add"),
                     ("foo", "bar"),
                     ("paper", "title"),
                     ("badc", "baba")
                 })
        {
            var res = IsIsomorphic(s1, s2);
        }
    }

    private static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var arr1 = new int[256];
        var arr2 = new int[256];

        for (var i = 0; i < s.Length; ++i)
        {
            var (k1, k2) = (s[i], t[i]);

            if (arr1[k1] == 0 && arr2[k2] == 0)
            {
                (arr1[k1], arr2[k2]) = (k2, k1);

                continue;
            }

            if (!(arr1[k1] == k2 && arr2[k2] == k1))
            {
                return false;
            }
        }

        return true;
    }
}