namespace Tennis
{
    internal class ScoreEqual : IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            if (scoringData.ScoreEqual)
            {
                if (scoringData.Points1 >= 4)
                {
                    scoringData.Score = "Deuce";
                }
                else
                {
                    scoringData.Score = scoringData.Player1PointsName + "-All";
                }
            }
        }
    }
}