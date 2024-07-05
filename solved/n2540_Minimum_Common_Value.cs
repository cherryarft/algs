namespace Alg.solved;

public static class n2540_Minimum_Common_Value
{
    public static void Run()
    {
        foreach (var arr in new int[][][]
                 {
                     [[1, 2, 3], [2, 4]],
                     [[1, 2, 3, 6], [2, 3, 4, 5]]
                 })
        {
            var res = GetCommon(arr[0], arr[1]);
        }
    }

    static int GetCommon(int[] nums1, int[] nums2)
    {
        var (f, s) = (0, 0);

        while (nums1.Length != f && nums2.Length != s)
        {
            var (fv, sv) = (nums1[f], nums2[s]);

            if (fv == sv) return fv;

            _ = fv < sv ? f++ : s++;
        }

        return -1;
    }
}