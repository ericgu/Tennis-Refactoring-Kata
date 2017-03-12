namespace Tennis
{
    internal class ScoreEqual
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null && scoringData.IsScoreEqual)
            {
                score = scoringData.Player1PointsName + "-All";
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}