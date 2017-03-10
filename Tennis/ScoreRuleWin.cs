namespace Tennis
{
    internal class ScoreRuleWin : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            if (CheckForWin(player1, player2))
            {
                return "Win for " + player1.Name;
            }

            if (CheckForWin(player2, player1))
            {
                return "Win for " + player2.Name;
            }

            return null;
        }

        private static bool CheckForWin(Player player, Player otherPlayer)
        {
            return player.Score.Value >= 4 && player.Score.Value - otherPlayer.Score.Value >= 2;
        }
    }
}