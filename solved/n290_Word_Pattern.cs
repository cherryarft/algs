namespace Alg.solved;

public static class n290_Word_Pattern
{
    public static void Run()
    {
        foreach (var (pattern, s) in new[]
                 {
                     ("abba", "dog cat cat dog"),
                     ("abba", "dog cat cat fish"),
                     ("aaaa", "dog cat cat dog"),
                 })
        {
            var res = WordPattern(pattern, s);
        }
    }

    private static bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (words.Length != pattern.Length) return false;

        var arr = new string?[26];
        var dic = new Dictionary<string, int>();

        for (var i = 0; i < pattern.Length; ++i)
        {
            var k1 = pattern[i] - 'a';
            var k2 = words[i];

            if (arr[k1] is null && !dic.ContainsKey(k2))
            {
                arr[k1] = k2;
                dic.Add(k2, k1);

                continue;
            }

            if (!(arr[k1] == k2 && dic[k2] == k1))
            {
                return false;
            }
        }

        return true;
    }
}