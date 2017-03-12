namespace Tennis
{
    internal class ScoreEqual : IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null && scoringData.ScoreEqual)
            {
                if (scoringData.Points1 >= 3)
                {
                    score = "Deuce";
                }
                else
                {
                    score = scoringData.Player1PointsName + "-All";
                }
            }

            if (ScoreReady != null)
            {
                ScoreReady(scoringData, score);
            }
        }
    }
}