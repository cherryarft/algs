namespace Alg.solved;

public static class n1189_Maximum_Number_of_Balloons
{
    public static void Run()
    {
        foreach (var arr in new string[]
                 {
                     "loonbalxballpoon",
                     "krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw",
                     "balon",
                     "nlaebolko",
                     "loonbalxballpoon",
                     "leetcode"
                 })
        {
            var res = MaxNumberOfBalloons(arr);
        }
    }

    static int MaxNumberOfBalloons(string text)
    {
        Span<int> arr = stackalloc int[5];

        foreach (var c in text)
        {
            switch (c)
            {
                case 'b':
                    arr[0] += 1;
                    break;
                case 'a':
                    arr[1] += 1;
                    break;
                case 'l':
                    arr[2] += 1;
                    break;
                case 'o':
                    arr[3] += 1;
                    break;
                case 'n':
                    arr[4] += 1;
                    break;

                default:
                    continue;
            }
        }

        return Math.Min(Math.Min(arr[2], arr[3]) / 2, Math.Min(Math.Min(arr[0], arr[1]), arr[4]));
    }
}