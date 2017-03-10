namespace Tennis
{
    internal class ScoreRuleAdvantage : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            if (InAdvantageAndUpByOne(gameState.Player1, gameState.Player2))
            {
                return "Advantage " + gameState.Player1.Name;
            }

            if (InAdvantageAndUpByOne(gameState.Player2, gameState.Player1))
            {
                return "Advantage " + gameState.Player2.Name;
            }

            return null;
        }

        private static bool InAdvantageAndUpByOne(Player player1, Player player2)
        {
            return player1.Score >= 4 && player1.Score - player2.Score == 1;
        }
    }
}