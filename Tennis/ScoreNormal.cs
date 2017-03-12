namespace Tennis
{
    internal class ScoreNormal
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (scoringData.IsScoringNormal)
            {
                score = scoringData.Player1PointsName + "-" + scoringData.Player2PointsName;
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}