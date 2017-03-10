using Tennis;

internal class ScoreRuleNormal : IScoreRule
{

    public string Evaluate(Player player1, Player player2)
    {
        return Evaluate(player1.Score, player2.Score);
    }
    public string Evaluate(int mScore1, int mScore2)
    {
        return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
    }
}