namespace Alg.solved;

public static class n567_Permutation_in_String
{
    public static void Run()
    {
        foreach (var (s1, s2) in new[]
                 {
                     ("ab", "eidbaooo"),
                     ("ab", "eidboaoo"),
                 })
        {
            var res = CheckInclusion(s1, s2);
        }
    }

    private static bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var arr1 = new int[26];
        var arr2 = new int[26];

        for (var i = 0; i < s1.Length; ++i)
        {
            arr1[s1[i] - 'a'] += 1;
            arr2[s2[i] - 'a'] += 1;
        }

        for (var i = 0; i < s2.Length - s1.Length; ++i)
        {
            if (Check(arr1, arr2))
            {
                return true;
            }

            arr2[s2[i + s1.Length] - 'a']++;
            arr2[s2[i] - 'a']--;
        }


        return Check(arr1, arr2);

        static bool Check(int[] arr1, int[] arr2)
        {
            for (var i = 0; i < 26; ++i)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}