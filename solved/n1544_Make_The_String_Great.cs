namespace Alg.solved;

public sealed class n1544_Make_The_String_Great
{
    public static void Run()
    {
        foreach (var str in new[]
                 {
                     "leEeetcode",
                     "abBAcC"
                 })
        {
            var res = MakeGood(str);
        }
    }

    private static string MakeGood(string s)
    {
        var st = new Stack<char>();

        foreach (var c in s)
        {
            if (st.TryPeek(out var v) && Math.Abs(v - c) == 32)
            {
                st.Pop();
            }
            else
            {
                st.Push(c);
            }
        }

        return st.Count != 0 ? new string(st.Reverse().ToArray()) : string.Empty;
    }
}