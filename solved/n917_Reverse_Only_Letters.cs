namespace Alg.solved;

public static class n917_Reverse_Only_Letters
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     "ab-cd",
                     "a-bC-dEf-ghIj",
                     "Test1ng-Leet=code-Q!"
                 })
        {
            var res = ReverseOnlyLetters(arr);
        }
    }

    static string ReverseOnlyLetters(string s)
    {
        var arr = s.ToCharArray();

        if (arr.Length < 2) return s;

        var (left, right) = (0, arr.Length - 1);

        while (true)
        {
            while (true)
            {
                if (!(left < right)) return new string(arr);

                if (IsLetter(arr[left]))
                {
                    break;
                }

                left++;
            }

            while (true)
            {
                if (!(left < right)) return new string(arr);

                if (IsLetter(arr[right]))
                {
                    break;
                }

                right--;
            }

            (arr[left], arr[right]) = (arr[right], arr[left]);

            ++left;
            --right;
        }

        static bool IsLetter(char c) => (int)c is >= 65 and <= 90 || (int)c is >= 97 and <= 122;
    }
}