namespace Tennis
{
    internal static class ScoreDeuceClass
    {
        public static ScoringData ScoreDeuce(this ScoringData scoringData)
        {
            if (scoringData.IsDeuce)
            {
                return new ScoringData(scoringData, "Deuce");
            }

            return scoringData;
        }
    }
}