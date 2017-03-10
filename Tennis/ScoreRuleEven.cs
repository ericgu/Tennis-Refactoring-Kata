namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            if (player1.Score.Value == player2.Score.Value)
            {
                if (player1.Score.Value >= 3)
                {
                    return "Deuce";
                }

                return player1.Score.ScoreWord + "-All";
            }

            return null;
        }
    }
}