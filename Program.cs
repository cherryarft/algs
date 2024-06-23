using System.Collections;
using System.Runtime.InteropServices;

var arr = new int[] { 1, 2, 1, 3, 4, 4, 3, 1 };

// 1 2 3 4

var set = new HashSet<int>(arr);

var a = -1;

Run();

static void Run()
{
    foreach (var arr in new int[][]
             {
                 [5, 7, 3, 9, 4, 9, 8, 3, 1],
                 [9, 9, 8, 8]
             })
    {
        var res = FindMaxLength(arr);
    }


    // foreach (var arr in new string[]
    //          {
    //              "loonbalxballpoon",
    //              "krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw",
    //              "balon",
    //              "nlaebolko",
    //              "loonbalxballpoon",
    //              "leetcode"
    //          })
    // {
    //     var res = MaxNumberOfBalloons(arr);
    // }

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

    // foreach (var arr in new int[][][]
    //          {
    //              [[1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]],
    //              [[2, 3], [1, 3], [5, 4], [6, 4]]
    //          })
    // {
    //     var res = FindWinners(arr);
    // }
}

static int FindMaxLength(int[] nums)
{
    return default;
}


/*
 * -7, -6, -5, -3, -2, -1
 *  -1, -2, -3, 25, 36, 49
 */