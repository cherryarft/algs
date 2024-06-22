namespace Alg.solved;

public class n1832_Check_if_the_Sentence_Is_Pangram
{
    public static void Run()
    {
        foreach (var str in new[] { "thequickbrownfoxjumpsoverthelazydog", "leetcode" })
        {
            var res = CheckIfPangram(str);
        }
    }

    static bool CheckIfPangram(string sentence)
    {
        var set = new HashSet<char>(sentence.ToCharArray());

        return set.Count == 26;
    }
}