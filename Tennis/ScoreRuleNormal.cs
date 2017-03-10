namespace Tennis
{
    internal class ScoreRuleNormal : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return gameState.Player1.Score.ScoreWord + "-" + gameState.Player2.Score.ScoreWord;
        }
    }
}