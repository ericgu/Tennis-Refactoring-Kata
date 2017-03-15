namespace Tennis
{
    internal static class ScoreWinClass
    {
        public static ScoringData ScoreWin(this ScoringData scoringData)
        {
            if (scoringData.EitherPlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage >= 2)
                {
                    return new ScoringData(scoringData, "Win for " + scoringData.Player1Name);
                }
                else if (scoringData.Player2PointAdvantage >= 2)
                {
                    return new ScoringData(scoringData, "Win for " + scoringData.Player2Name);
                }
            }

            return scoringData;
        }
    }
}