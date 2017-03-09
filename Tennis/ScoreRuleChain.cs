using System.Data.SqlTypes;

internal class ScoreRuleChain
{
    private IScoreRule[] _scoreRules;

    public ScoreRuleChain(IScoreRule[] scoreRules)
    {
        _scoreRules = scoreRules;
    }

    public string Evaluate(int mScore2, int mScore1)
    {
        foreach (IScoreRule rule in _scoreRules)
        {
            string score = rule.Evaluate(mScore1, mScore2);
            if (score != null)
            {
                return score;
            }
        }

        return "Score Error";
    }
}