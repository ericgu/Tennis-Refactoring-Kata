namespace Tennis
{
    internal class ScoreRuleNormal : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return ScoreWords.GetScoreWord(gameState.Player1.Score) + "-" + ScoreWords.GetScoreWord(gameState.Player2.Score);
        }
    }
}