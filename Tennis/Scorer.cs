namespace Tennis
{
    internal class Scorer
    {
        public delegate void ScoreHandler(ScoringData scoringData);

        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            string score = "";
            if (scoringData.ScoreEqual)
            {
                if (scoringData.Points1 >= 4)
                {
                    score = "Deuce";
                }
                else
                {
                    score = scoringData.Player1PointsName + "-All";
                }
            }
            else if (scoringData.OnePlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1) score = "Advantage " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage == 1) score = "Advantage " + scoringData.Player2Name;
                else if (scoringData.Player1PointAdvantage == 2) score = "Win for " + scoringData.Player1Name;
                else if (scoringData.Player2PointAdvantage == 2) score = "Win for " + scoringData.Player2Name;
            }
            else
            {
                score = scoringData.Player1PointsName + "-" + scoringData.Player1PointsName;
            }

            scoringData.Score = score;

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}