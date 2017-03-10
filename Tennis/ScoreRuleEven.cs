namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            if (player1.Score == player2.Score)
            {
                if (player1.Score >= 3)
                {
                    return "Deuce";
                }

                return ScoreWords.GetScoreWord(player1.Score) + "-All";
            }

            return null;
        }
    }
}