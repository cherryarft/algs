using System.Text;

namespace Alg.solved;

public static class n451_Sort_Characters_By_Frequency
{
    public static void Run()
    {
        foreach (var str in new[]
                 {
                     "tree",
                     "cccaaa",
                     "Aabb"
                 })
        {
            var res = FrequencySort(str);
        }
    }

    private static string FrequencySort(string s)
    {
        var dic = new Dictionary<char, int>();

        var max = 1;
        foreach (var c in s.ToArray())
        {
            if (dic.TryAdd(c, 1))
            {
                continue;
            }

            var v = dic[c] + 1;

            if (max < v)
            {
                max = v;
            }

            dic[c] = v;
        }

        var buckets = new List<char>[max + 1];

        for (var i = 0; i < buckets.Length; ++i)
        {
            buckets[i] = [];
        }

        foreach (var (k, v) in dic)
        {
            buckets[v].Add(k);
        }

        var sb = new StringBuilder(s.Length);
        for (var i = buckets.Length - 1; i != -1; --i)
        {
            foreach (var c in buckets[i])
            {
                for (var t = i; t != 0; --t)
                {
                    sb.Append(c);
                }
            }
        }

        var res = sb.ToString();

        return res;
    }
}