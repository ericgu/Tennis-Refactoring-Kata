namespace Tennis
{
    internal class ScoreRuleAdvantage : IScoreRule
    {
        private readonly string _player1Name;
        private readonly string _player2Name;

        public ScoreRuleAdvantage(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string Evaluate(Player player1, Player player2)
        {
            int mScore1 = player1.Score;
            int mScore2 = player2.Score;
            string score = null;
            if (mScore1 >= 4 || mScore2 >= 4)
            {
                var minusResult = mScore1 - mScore2;
                if (minusResult == 1) score = "Advantage " + _player1Name;
                else if (minusResult == -1) score = "Advantage " + _player2Name;

                return score;
            }
            return null;
        }
    }
}