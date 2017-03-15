namespace Tennis
{
    internal static class ScoringRules
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

        public static ScoringData ScoreDeuce(this ScoringData scoringData)
        {
            if (scoringData.IsDeuce)
            {
                return new ScoringData(scoringData, "Deuce");
            }

            return scoringData;
        }

        public static ScoringData ScoreEqual(this ScoringData scoringData)
        {
            if (!scoringData.IsDeuce && scoringData.IsScoreEqual)
            {
                return new ScoringData(scoringData, scoringData.Player1PointsName + "-All");
            }

            return scoringData;
        }

        public static ScoringData ScoreNormal(this ScoringData scoringData)
        {
            if (scoringData.IsScoringNormal)
            {
                return new ScoringData(scoringData, scoringData.Player1PointsName + "-" + scoringData.Player2PointsName);
            }

            return scoringData;
        }

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