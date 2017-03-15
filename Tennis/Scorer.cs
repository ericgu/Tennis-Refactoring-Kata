namespace Tennis
{
    internal class Scorer
    {
        public string Score(ScoringData scoringData)
        {
            return scoringData.ScoreDeuce().ScoreEqual().ScoreAdvantage().ScoreNormal().ScoreWin().Score;
        }
    }
}