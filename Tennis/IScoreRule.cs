namespace Tennis
{
    internal interface IScoreRule
    {
        string Evaluate(GameState gameState);
    }
}