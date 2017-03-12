namespace Tennis
{
    internal class ScoreNormal: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            if (scoringData.Score == null)
            {
                scoringData.Score = scoringData.Player1PointsName + "-" + scoringData.Player2PointsName;
            }

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}