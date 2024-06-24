using System.Runtime.InteropServices;

namespace Alg.solved;

public static class n2225_Find_Players_With_Zero_or_One_Losses
{
    public static void Run()
    {
        foreach (var arr in new int[][][]
                 {
                     [[1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]],
                     [[2, 3], [1, 3], [5, 4], [6, 4]]
                 })
        {
            var res = FindWinners(arr);
        }
    }

    static IList<IList<int>> FindWinners(int[][] matches)
    {
        var players = new Dictionary<int, int>();

        foreach (var match in matches)
        {
            ref var score = ref CollectionsMarshal.GetValueRefOrAddDefault(players, match[0], out _);
            score = ref CollectionsMarshal.GetValueRefOrAddDefault(players, match[1], out _);
            score += 1;
        }

        var winners = new List<int>();
        var losers = new List<int>();

        foreach (var (player, loses) in players)
        {
            switch (loses)
            {
                case 0:
                    winners.Add(player);
                    break;
                case 1:
                    losers.Add(player);
                    break;

                default:
                    continue;
            }
        }

        winners.Sort();
        losers.Sort();

        return new List<IList<int>> { winners, losers };
    }
}