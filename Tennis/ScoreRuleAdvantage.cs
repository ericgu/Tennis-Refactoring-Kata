namespace Tennis
{
    internal class ScoreRuleAdvantage : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            string score = null;
            if (player1.Score >= 4 || player2.Score >= 4)
            {
                var minusResult = player1.Score - player2.Score;
                if (minusResult == 1) score = "Advantage " + player1.Name;
                else if (minusResult == -1) score = "Advantage " + player2.Name;

                return score;
            }
            return null;
        }
    }
}