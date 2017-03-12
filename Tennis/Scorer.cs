namespace Tennis
{
    internal class Scorer : IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            string score = "";
            if (scoringData.ScoreEqual)
            {
                new ScoreEqual().Score(scoringData);
            }
            else if (scoringData.OnePlayerScoredFourOrHigher)
            {
                new ScoreAdvantageOrWin().Score(scoringData);
            }
            else
            {
                new ScoreNormal().Score(scoringData);
            }

            scoringData.Score = score;

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}