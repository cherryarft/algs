namespace Alg.solved;

public static class n1456_MaximumNumber_of_Vowels_in_a_Substring_of_Given_Length
{
    public static void Run()
    {
        foreach (var (str, c) in new[]
                 {
                     ("abciiidef", 3),
                     ("aeiou", 2),
                     ("leetcode", 3)
                 })
        {
            var res = MaxVowels(str, c);
        }
    }

    static int MaxVowels(string s, int k)
    {
        var (max, cur) = (0, 0);
        var (left, right) = (0, 0);

        var arr = s.ToCharArray();

        while (right < arr.Length)
        {
            if (IsVowel(arr[right]))
            {
                cur++;
            }

            if (right - left + 1 > k)
            {
                if (IsVowel(arr[left]))
                {
                    cur--;
                }

                left++;
            }

            if (max < cur)
            {
                max = cur;
            }

            right++;
        }

        return max;

        static bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}