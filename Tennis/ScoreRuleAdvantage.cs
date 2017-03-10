namespace Tennis
{
    internal class ScoreRuleAdvantage : IScoreRule
    {
        public string Evaluate(Player player1, Player player2)
        {
            int mScore1 = player1.Score;
            int mScore2 = player2.Score;
            string score = null;
            if (mScore1 >= 4 || mScore2 >= 4)
            {
                var minusResult = mScore1 - mScore2;
                if (minusResult == 1) score = "Advantage " + player1.Name;
                else if (minusResult == -1) score = "Advantage " + player2.Name;

                return score;
            }
            return null;
        }
    }
}