namespace Tennis
{
    internal class ScoreAdvantageOrWin: IScorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            if (scoringData.Score == null && scoringData.OnePlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1) scoringData.Score = "Advantage " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage == 1)
                    scoringData.Score = "Advantage " + scoringData.Player2Name;
                else if (scoringData.Player1PointAdvantage >= 2)
                    scoringData.Score = "Win for " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage >= 2)
                    scoringData.Score = "Win for " + scoringData.Player2Name;
            }

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}