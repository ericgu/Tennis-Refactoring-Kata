namespace Tennis
{
    internal class ScoreWin: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null && scoringData.OnePlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage >= 2)
                   score = "Win for " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage >= 2)
                    score = "Win for " + scoringData.Player2Name;
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}