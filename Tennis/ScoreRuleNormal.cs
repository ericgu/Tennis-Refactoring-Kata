static internal class ScoreRuleNormal
{
    public static string Evaluate(int mScore2, int mScore1)
    {
        return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
    }
}