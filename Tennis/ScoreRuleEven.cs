namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {
        public string GetScore(Player player1, Player player2)
        {
            if (player1.Points == player2.Points)
            {
                if (player1.Points >= 3)
                {
                    return "Deuce";
                }

                return ScoreWords.GetScoreWord(player1.Points) + "-All";
            }

            return null;
        }
    }
}