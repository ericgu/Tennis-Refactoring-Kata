namespace Tennis
{
    internal interface IScoreRule
    {
        string GetScore(Player player1, Player player2);
    }
}