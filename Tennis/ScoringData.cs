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
}