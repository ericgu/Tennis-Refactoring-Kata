namespace Tennis
{
    internal class ScoreRuleNormal : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            return player1.Score.ScoreWord + "-" + player2.Score.ScoreWord;
        }
    }
}