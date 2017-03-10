namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            if (gameState.Player1.Score == gameState.Player2.Score)
            {
                if (gameState.Player1.Score >= 3)
                {
                    return "Deuce";
                }

                return ScoreWords.GetScoreWord(gameState.Player1.Score) + "-All";
            }

            return null;
        }
    }
}