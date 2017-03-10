using Tennis;

internal interface IScoreRule
{
    string Evaluate(int mScore1, int mScore2);
    string Evaluate(Player player1, Player player2);
}