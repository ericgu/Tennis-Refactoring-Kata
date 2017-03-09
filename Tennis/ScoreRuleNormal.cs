internal class ScoreRuleNormal : IScoreRule
{
    public string Evaluate(int mScore1, int mScore2)
    {
        return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
    }
}