internal class ScoringData
{
    public ScoringData(int points1, int points2, string player1Name, string player2Name)
    {
        Points1 = points1;
        Points2 = points2;
        Player1Name = player1Name;
        Player2Name = player2Name;
    }

    public int Points1 { get; }

    public int Points2 { get; }

    public string Player1Name { get; }

    public string Player2Name { get; }

    public string Score { get; set; }

    public bool OnePlayerScoredFourOrHigher
    {
        get { return Points1 >= 4 || Points2 >= 4; }
    }

    public bool ScoreEqual
    {
        get { return Points1 == Points2; }
    }

    public int Player1PointAdvantage
    {
        get
        {
            if (Points1 > Points2)
            {
                return Points1 - Points2;
            }

            return 0;
        }
    }

    public int Player2PointAdvantage
    {
        get
        {
            if (Points2 > Points1)
            {
                return Points2 - Points1;
            }

            return 0;
        }
    }
}