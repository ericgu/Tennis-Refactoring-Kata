internal class Scorer
{
    public delegate void ScoreHandler(string score);

    public event ScoreHandler ScoreReady;

    public void GetScoreInternal(int points1, int points2, string player1Name, string player2Name)
    {
        string score = "";
        if (points1 == points2)
        {
            switch (points1)
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
        else if (points1 >= 4 || points2 >= 4)
        {
            var minusResult = points1 - points2;
            if (minusResult == 1) score = "Advantage " + player1Name;
            else if (minusResult == -1) score = "Advantage " + player2Name;
            else if (minusResult >= 2) score = "Win for " + player1Name;
            else score = "Win for " + player2Name;
        }
        else
        {
            for (var i = 1; i < 3; i++)
            {
                int tempScore;
                if (i == 1) tempScore = points1;
                else
                {
                    score += "-";
                    tempScore = points2;
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

        if (ScoreReady != null)
        {
            ScoreReady(score);
        }
    }
}