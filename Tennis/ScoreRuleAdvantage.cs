namespace Tennis
{
    internal class ScoreRuleAdvantage : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            if (InAdvantageAndUpByOne(player1, player2))
            {
                return "Advantage " + player1.Name;
            }

            if (InAdvantageAndUpByOne(player2, player1))
            {
                return "Advantage " + player2.Name;
            }

            return null;
        }

        private static bool InAdvantageAndUpByOne(Player player, Player otherPlayer)
        {
            return player.Score >= 4 && player.Score - otherPlayer.Score == 1;
        }
    }
}