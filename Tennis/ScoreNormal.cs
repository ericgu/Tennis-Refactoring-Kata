namespace Tennis
{
    internal class ScoreNormal: ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            string score = null;
            if (scoringData.IsScoringNormal)
            {
                score = scoringData.Player1PointsName + "-" + scoringData.Player2PointsName;
            }
            return score;
        }
    }
}