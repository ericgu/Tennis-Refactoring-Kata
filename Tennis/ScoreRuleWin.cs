namespace Tennis
{
    internal class ScoreRuleWin : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            string score;
            if (player1.Score >= 4 || player2.Score >= 4)
            {
                var minusResult = player1.Score - player2.Score;
                if (minusResult >= 2) score = "Win for " + player1.Name;
                else score = "Win for " + player2.Name;

                return score;
            }
            return null;
        }
    }
}