namespace Tennis
{
    internal class ScoreAdvantage
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null && scoringData.APlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1)
                {
                    score = "Advantage " + scoringData.Player1Name;
                }
                else if (scoringData.Player2PointAdvantage == 1)
                {
                    score = "Advantage " + scoringData.Player2Name;
                }
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}