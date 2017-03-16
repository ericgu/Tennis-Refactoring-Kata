namespace Tennis
{
    internal static class Scorer
    {
        public static string ScoreIt(this ScoringData scoringData)
        {
            return scoringData.ScoreDeuce().ScoreEqual().ScoreAdvantage().ScoreNormal().ScoreWin().Score;
        }
    }
}