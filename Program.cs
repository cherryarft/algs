using System.Collections;
using System.Runtime.InteropServices;

Run();

static void Run()
{
    foreach (var str in new[]
             {
                 "abcabcbb",
                 "abcbab",
                 "abba",
                 "dvdf",
                 "abcabcbb",
                 "bbbbb",
                 "pwwkew"
             })
    {
        var res = LengthOfLongestSubstring(str);
    }
}

static int LengthOfLongestSubstring(string s)
{
    var (arr, dic) = (s.ToCharArray(), new Dictionary<char, int>());
    var (left, right, max) = (0, 0, 0);

    while (right < arr.Length)
    {
        var c = arr[right];

        if (!dic.TryAdd(c, right))
        {
            var duplicate = dic[c];

            if (left <= duplicate)
            {
                left = duplicate + 1;
            }

            dic[c] = right;
        }

        var cur = right - left + 1;

        if (max < cur)
        {
            max = cur;
        }

        right++;
    }

    return max;
}