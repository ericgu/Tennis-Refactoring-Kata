static internal class ScoreRuleEven
{
    public static string ScoreRuleEvenFunc(int mScore2, int mScore1)
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