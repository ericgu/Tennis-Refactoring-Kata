internal class ScoreRuleAdvantage : IScoreRule
{
    public string Evaluate(int mScore2, int mScore1)
    {
        string score = null;
        if (mScore1 >= 4 || mScore2 >= 4)
        {
            var minusResult = mScore1 - mScore2;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";

            return score;
        }
        return null;
    }
}