internal class Scorer
{
    public delegate void ScoreHandler(string score);

    public event ScoreHandler ScoreReady;

    public void GetScoreInternal(ScoringData scoringData)
    {
        string score = "";
        if (scoringData.Points1 == scoringData.Points2)
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
        else if (scoringData.Points1 >= 4 || scoringData.Points2 >= 4)
        {
            var minusResult = scoringData.Points1 - scoringData.Points2;
            if (minusResult == 1) score = "Advantage " + scoringData.Player1Name;
            else if (minusResult == -1) score = "Advantage " + scoringData.Player2Name;
            else if (minusResult >= 2) score = "Win for " + scoringData.Player1Name;
            else score = "Win for " + scoringData.Player2Name;
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