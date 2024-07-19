using System.Text;

namespace Alg.solved;

public static class n791_Custom_Sort_String
{
    public static void Run()
    {
        foreach (var (order, s) in new[]
                 {
                     ("cba", "abcd"),
                     ("bcafg", "abcd"),
                 })
        {
            var res = CustomSortString(order, s);
        }
    }

    private static string CustomSortString(string order, string s)
    {
        var arr = new int[26];

        foreach (var c in s)
        {
            arr[c - 'a'] += 1;
        }

        var sb = new StringBuilder(s.Length);

        foreach (var c in order)
            while (arr[c - 'a']-- > 0)
            {
                sb.Append(c);
            }

        for (var i = 0; i < arr.Length; ++i)
            while (arr[i]-- > 0)
            {
                sb.Append((char)(i + 'a'));
            }

        var res = sb.ToString();

        return res;
    }
}