namespace Alg.solved;

public static class n2000_Reverse_Prefix_of_Word
{
    public static void Run()
    {
        foreach (var (str, c) in new[]
                 {
                     ("abcdefd", 'd'),
                     ("xyxzxe", 'z'),
                     ("abcd", 'z')
                 })
        {
            var res = ReversePrefix(str, c);
        }
    }

    static string ReversePrefix(string word, char ch)
    {
        var (left, right) = (0, 0);

        var arr = word.ToArray();

        while (right < arr.Length && arr[right] != ch)
        {
            right++;
        }

        if (right == arr.Length) return word;

        while (left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);

            ++left;
            --right;
        }

        return new string(arr);
    }
}