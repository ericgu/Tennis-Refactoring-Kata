namespace Tennis
{
    internal static class ScoreNormalClass
    {
        public static ScoringData ScoreNormal(this ScoringData scoringData)
        {
            if (scoringData.IsScoringNormal)
            {
                return new ScoringData(scoringData, scoringData.Player1PointsName + "-" + scoringData.Player2PointsName);
            }

            return scoringData;
        }
    }
}