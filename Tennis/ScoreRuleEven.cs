namespace Tennis
{
    internal class ScoreRuleEven : IScoreRule
    {

        public string Evaluate(Player player1, Player player2)
        {
            return Evaluate(player1.Score, player2.Score);
        }

        public string Evaluate(int mScore1, int mScore2)
        {
            if (mScore1 == mScore2)
            {
                if (mScore1 == 3)
                {
                    return "Deuce";
                }

                return ScoreWords.GetScoreWord(mScore1) + "-All";
            }

            return null;
        }
    }
}