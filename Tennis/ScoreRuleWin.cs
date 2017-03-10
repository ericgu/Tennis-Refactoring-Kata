namespace Tennis
{
    internal class ScoreRuleWin : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            if (CheckForWin(gameState.Player1, gameState.Player2))
            {
                return "Win for " + gameState.Player1.Name;
            }

            if (CheckForWin(gameState.Player2, gameState.Player1))
            {
                return "Win for " + gameState.Player2.Name;
            }

            return null;
        }

        private static bool CheckForWin(Player player1, Player player2)
        {
            return player1.Score >= 4 && player1.Score - player2.Score >= 2;
        }
    }
}