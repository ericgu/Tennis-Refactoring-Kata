namespace Tennis
{
    internal interface IScoreRule
    {
        string Evaluate(Player player1, Player player2);
    }
}