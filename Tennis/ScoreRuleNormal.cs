internal class ScoreRuleNormal : IScoreRule
{
    public string Evaluate(int mScore2, int mScore1)
    {
        return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
    }
}