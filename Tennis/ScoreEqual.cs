namespace Tennis
{
    internal static class ScoreEqualClass
    {
        public static ScoringData ScoreEqual(this ScoringData scoringData)
        {
            if (!scoringData.IsDeuce && scoringData.IsScoreEqual)
            {
                return new ScoringData(scoringData, scoringData.Player1PointsName + "-All");
            }

            return scoringData;
        }
    }
}