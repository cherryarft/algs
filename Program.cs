Run();

static void Run()
{
    foreach (var (arr, k) in new List<(int[], int)>
             {
                 ([7, 4, 3, 9, 1, 8, 5, 2, 6], 3),
                 ([100000], 0),
                 ([8], 100000)
             })
    {
        var res = GetAverages(arr, k);
    }
}

static int[] GetAverages(int[] nums, int k)
{
    if (k == 0) return nums;

    var windowsSize = k + k + 1;

    if (windowsSize > nums.Length)
    {
        for (var i = 0; i < nums.Length; ++i)
        {
            nums[i] = -1;
        }

        return nums;
    }

    var sum = 0d;

    for (var i = 0; i < windowsSize; ++i)
    {
        sum += nums[i];
    }

    var avgs = new int[nums.Length];

    for (var i = k; i < avgs.Length - k; ++i)
    {
        avgs[i] = (int)(sum / windowsSize);

        sum -= nums[i - k];
        sum += nums[(i + k + 1) % nums.Length];
    }

    for (var i = 0; i < k; ++i)
    {
        avgs[i] = avgs[avgs.Length - 1 - i] = -1;
    }

    return avgs;
}


return 0;

/*
 * -7, -6, -5, -3, -2, -1
 *  -1, -2, -3, 25, 36, 49
 */