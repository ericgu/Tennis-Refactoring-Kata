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

        private static bool InAdvantageAndUpByOne(Player player1, Player player2)
        {
            return player1.Score.Value >= 4 && player1.Score.Value - player2.Score.Value == 1;
        }
    }
}