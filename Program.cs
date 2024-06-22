var arr = new int[] { 1, 2, 1, 3, 4, 4, 3, 1 };

// 1 2 3 4

var set = new HashSet<int>(arr);

var a = -1;

Run();

static void Run()
{
    foreach (var arr in new int[][]
             {
                 [1, 2, 3],
                 [1, 1, 3, 3, 5, 5, 7, 7]
             })
    {
        var res = CountElements(arr);
    }

    // foreach (var (arr, k) in new List<(int[], int)>
    //          {
    //              ([7, 4, 3, 9, 1, 8, 5, 2, 6], 3),
    //              ([100000], 0),
    //              ([8], 100000)
    //          })
    // {
    //     var res = GetAverages(arr, k);
    // }

    // foreach (var str in new[] { "thequickbrownfoxjumpsoverthelazydog", "leetcode" })
    // {
    //     var res = CheckIfPangram(str);
    // }
}

static int CountElements(int[] arr)
{
    var set = new HashSet<int>(arr);

    return arr.Count(x => set.Contains(x + 1));
}


return 0;

/*
 * -7, -6, -5, -3, -2, -1
 *  -1, -2, -3, 25, 36, 49
 */