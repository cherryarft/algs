using System.Collections;
using System.Runtime.InteropServices;

Run();

static void Run()
{
    // foreach (var arr in new int[][]
    //          {
    //              [0, 1, 0, 3, 12],
    //              [0]
    //          })
    // {
    //     MoveZeroes(arr);
    // }

    // foreach (var (str, c) in new[]
    //          {
    //              ("abcdefd", 'd'),
    //              ("xyxzxe", 'z'),
    //              ("abcd", 'z')
    //          })
    // {
    //     var res = ReversePrefix(str, c);
    // }

    // foreach (var arr in new (string, string)[]
    //          {
    //              ("a", "b"),
    //              ("aa", "ab"),
    //              ("aa", "aab")
    //          })
    // {
    //     var res = CanConstruct(arr.Item1, arr.Item2);
    // }


    // foreach (var arr in new string[]
    //          {
    //              "ab-cd",
    //              "a-bC-dEf-ghIj",
    //              "Test1ng-Leet=code-Q!"
    //          })
    // {
    //     var res = ReverseOnlyLetters(arr);
    // }

    foreach (var (arr, k) in new (int[], int)[]
             {
                 ([2, 3, 1, 2, 4, 3], 7),
                 ([1, 4, 4], 4),
                 ([1, 1, 1, 1, 1, 1, 1, 1], 11)
             })
    {
        var res = MinSubArrayLen(k, arr);
    }

    // foreach (var str in new[] { "thequickbrownfoxjumpsoverthelazydog", "leetcode" })
    // {
    //     var res = CheckIfPangram(str);
    // }

    // foreach (var arr in new int[][][]
    //          {
    //              [[1, 2, 3], [2, 4]],
    //              [[1, 2, 3, 6], [2, 3, 4, 5]]
    //          })
    // {
    //     var res = GetCommon(arr[0], arr[1]);
    // }
}

static int MinSubArrayLen(int target, int[] nums)
{
    var (left, right) = (0, 0);

    var min = nums.Length;
    var sum = 0;

    while (right < nums.Length)
    {
        sum += nums[right];

        while (sum >= target)
        {
            var length = right - left + 1;
            if (length < min)
            {
                min = length;
            }

            sum -= nums[left++];
        }

        right++;
    }

    return left == 0 ? 0 : min;
}


/*
 * -7, -6, -5, -3, -2, -1
 *  -1, -2, -3, 25, 36, 49
 */