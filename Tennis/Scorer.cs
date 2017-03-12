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
                switch (scoringData.Points1)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;
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
                for (var i = 1; i < 3; i++)
                {
                    int tempScore;
                    if (i == 1) tempScore = scoringData.Points1;
                    else
                    {
                        score += "-";
                        tempScore = scoringData.Points2;
                    }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }

            scoringData.Score = score;

            if (ScoreReady != null)
            {
                ScoreReady(scoringData);
            }
        }
    }
}