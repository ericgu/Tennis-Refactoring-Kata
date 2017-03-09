static internal class ScoreRuleNormal
{
    public static string ScoreRuleNormalFunc(int mScore2, int mScore1)
    {
        return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
    }
}