namespace Alg.solved;

public static class n1208_Get_Equal_Substrings_Within_Budget
{
    public static void Run()
    {
        foreach (var (s, t, cost) in new[]
                 {
                     ("abcd", "bcdf", 3),
                     ("abcd", "cdef", 3),
                     ("abcd", "acde", 0)
                 })
        {
            var res = EqualSubstring(s, t, cost);
        }
    }

    static int EqualSubstring(string s, string t, int maxCost)
    {
        var (left, right) = (0, 0);
        var (curCost, max) = (0, 0);

        var arr1 = s.ToCharArray();
        var arr2 = t.ToCharArray();

        while (right < arr1.Length)
        {
            curCost += Math.Abs(arr1[right] - arr2[right]);

            while (curCost > maxCost)
            {
                curCost -= Math.Abs(arr1[left] - arr2[left]);

                left++;
            }

            var length = right - left + 1;

            if (max < length)
            {
                max = length;
            }

            right++;
        }

        return max;
    }
}