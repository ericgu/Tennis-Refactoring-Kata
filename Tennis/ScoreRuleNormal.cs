namespace Tennis
{
    internal class ScoreRuleNormal : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            return ScoreWords.GetScoreWord(player1.Score) + "-" + ScoreWords.GetScoreWord(player2.Score);
        }
    }
}