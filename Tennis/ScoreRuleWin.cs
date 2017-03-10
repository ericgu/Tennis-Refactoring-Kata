using Tennis;

internal class ScoreRuleWin : IScoreRule
{
    public string Evaluate(Player player1, Player player2)
    {
        int mScore1 = player1.Score;
        int mScore2 = player2.Score;
        string score;
        if (mScore1 >= 4 || mScore2 >= 4)
        {
            var minusResult = mScore1 - mScore2;
            if (minusResult >= 2) score = "Win for " + player1.Name;
            else score = "Win for " + player2.Name;

            return score;
        }
        return null;
    }
}