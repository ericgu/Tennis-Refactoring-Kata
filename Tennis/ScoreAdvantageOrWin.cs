namespace Tennis
{
    internal class ScoreAdvantageOrWin: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (score == null && scoringData.OnePlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1)
                    score = "Advantage " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage == 1)
                    score = "Advantage " + scoringData.Player2Name;
                else if (scoringData.Player1PointAdvantage >= 2)
                   score = "Win for " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage >= 2)
                    score = "Win for " + scoringData.Player2Name;
            }

            if (ScoreReady != null)
            {
                ScoreReady(scoringData, score);
            }
        }
    }
}