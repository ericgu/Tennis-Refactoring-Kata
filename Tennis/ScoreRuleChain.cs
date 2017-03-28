namespace Tennis
{
    internal class ScoreRuleChain
    {
        private readonly IScoreRule[] _scoreRules;

        public ScoreRuleChain(params IScoreRule[] scoreRules)
        {
            _scoreRules = scoreRules;
        }

        public string GetScore(Player player1, Player player2)
        {
            foreach (IScoreRule rule in _scoreRules)
            {
                string score = rule.GetScore(player1, player2);
                if (score != null)
                {
                    return score;
                }
            }

            return "Score Error";
        }
    }
}