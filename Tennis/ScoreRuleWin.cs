internal class ScoreRuleWin : IScoreRule
{
    public string Evaluate(int mScore1, int mScore2)
    {
        string score;
        if (mScore1 >= 4 || mScore2 >= 4)
        {
            var minusResult = mScore1 - mScore2;
            if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";

            return score;
        }
        return null;
    }
}