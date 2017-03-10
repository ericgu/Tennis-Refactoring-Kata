using Tennis;

internal class ScoreRuleWin : IScoreRule
{
    private readonly string _player1Name;
    private readonly string _player2Name;

    public ScoreRuleWin(string player1Name, string player2Name)
    {
        _player1Name = player1Name;
        _player2Name = player2Name;
    }

    public string Evaluate(Player player1, Player player2)
    {
        int mScore1 = player1.Score;
        int mScore2 = player2.Score;
        string score;
        if (mScore1 >= 4 || mScore2 >= 4)
        {
            var minusResult = mScore1 - mScore2;
            if (minusResult >= 2) score = "Win for " + _player1Name;
            else score = "Win for " + _player2Name;

            return score;
        }
        return null;
    }
}