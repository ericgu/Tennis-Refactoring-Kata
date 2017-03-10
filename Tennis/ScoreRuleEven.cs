namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            if (gameState.Player1.Score.Value == gameState.Player2.Score.Value)
            {
                if (gameState.Player1.Score.Value >= 3)
                {
                    return "Deuce";
                }

                return gameState.Player1.Score.ScoreWord + "-All";
            }

            return null;
        }
    }
}