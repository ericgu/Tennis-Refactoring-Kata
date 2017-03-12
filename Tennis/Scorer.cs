namespace Tennis
{
    internal class Scorer : IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            new ScoreEqual().Score(scoringData);
            new ScoreAdvantageOrWin().Score(scoringData);
            new ScoreNormal().Score(scoringData);

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}