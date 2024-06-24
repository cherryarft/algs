using System.Runtime.InteropServices;

namespace Alg.solved;

public static class n383_Ransom_Note
{
    public static void Run()
    {
        foreach (var arr in new (string, string)[]
                 {
                     ("a", "b"),
                     ("aa", "ab"),
                     ("aa", "aab")
                 })
        {
            var res = CanConstruct(arr.Item1, arr.Item2);
        }
    }

    static bool CanConstruct(string ransomNote, string magazine)
    {
        var dic = new Dictionary<char, int>();

        foreach (var c in magazine)
        {
            ref var v = ref CollectionsMarshal.GetValueRefOrAddDefault(dic, c, out _);

            v += 1;
        }

        foreach (var c in ransomNote)
        {
            ref var v = ref CollectionsMarshal.GetValueRefOrAddDefault(dic, c, out _);

            if (v == 0) return false;

            v -= 1;
        }

        return true;
    }
}