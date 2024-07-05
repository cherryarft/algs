namespace Alg.solved;

public static class n557_Reverse_Words_in_a_String_III
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     "Let's take LeetCode contest",
                     "Mr Ding"
                 })
        {
            var res = ReverseWords(arr);
        }
    }

    static string ReverseWords(string s)
    {
        var arr = s.ToCharArray();

        if (arr.Length == 1) return s;

        var start = 0;
        while (Next(arr, start, out var end))
        {
            var (left, right) = (start, end);
            while (left < right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);

                ++left;
                --right;
            }

            start = end + 2;
        }

        return new string(arr);

        static bool Next(char[] arr, int start, out int end)
        {
            end = start;

            if (arr.Length <= end)
            {
                return false;
            }

            while (arr.Length != end && arr[end] != ' ')
            {
                ++end;
            }

            --end;
            return true;
        }
    }
}