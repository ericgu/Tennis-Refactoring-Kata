internal class ScoreRuleEven : IScoreRule
{
    public string Evaluate(int mScore1, int mScore2)
    {
        if (mScore1 == mScore2)
        {
            if (mScore1 == 3)
            {
                return "Deuce";
            }

            return ScoreWords.GetScoreWord(mScore1) + "-All";
        }

        return null;
    }
}