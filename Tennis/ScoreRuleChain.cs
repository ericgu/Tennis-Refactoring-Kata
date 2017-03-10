namespace Tennis
{
    internal class ScoreRuleChain
    {
        private readonly IScoreRule[] _scoreRules;

        public ScoreRuleChain(IScoreRule[] scoreRules)
        {
            _scoreRules = scoreRules;
        }

        public string Evaluate(Player player1, Player player2)
        {
            foreach (IScoreRule rule in _scoreRules)
            {
                string score = rule.Evaluate(player1, player2);
                if (score != null)
                {
                    return score;
                }
            }

            return "Score Error";
        }
    }
}