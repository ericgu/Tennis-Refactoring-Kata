namespace Tennis
{
    internal class ScoreRuleNormal : IScoreRule
    {
        public string GetScore(Player player1, Player player2)
        {
            return ScoreWords.GetScoreWord(player1.Points) + "-" + ScoreWords.GetScoreWord(player2.Points);
        }
    }
}