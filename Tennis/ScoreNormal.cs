namespace Tennis
{
    internal class ScoreNormal: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null)
            {
                score = scoringData.Player1PointsName + "-" + scoringData.Player2PointsName;
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}