namespace Tennis
{
    internal class ScoreNormal: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            scoringData.Score = scoringData.Player1PointsName + "-" + scoringData.Player1PointsName;
        }
    }
}