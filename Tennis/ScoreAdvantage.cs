namespace Tennis
{
    internal static class ScoreAdvantageClass
    {
        public static ScoringData ScoreAdvantage(this ScoringData scoringData)
        {
            if (scoringData.EitherPlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1)
                {
                    return new ScoringData(scoringData, "Advantage " + scoringData.Player1Name);
                }
                else if (scoringData.Player2PointAdvantage == 1)
                {
                    return new ScoringData(scoringData, "Advantage " + scoringData.Player2Name);
                }
            }

            return scoringData;
        }
    }
}