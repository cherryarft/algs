namespace Alg.solved;

public static class n344_Reverse_String
{
    public static void Run()
    {
        foreach (var arr in new char[][]
                 {
                     ['h', 'e', 'l', 'l', 'o'],
                     ['0', '1', '2', '3', '4']
                 })
        {
            ReverseString(arr);
        }
    }

    static void ReverseString(char[] s)
    {
        var (left, right) = (0, s.Length - 1);

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);

            ++left;
            --right;
        }
    }
}