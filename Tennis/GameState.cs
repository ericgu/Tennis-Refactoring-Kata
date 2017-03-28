namespace Tennis
{
    class GameState
    {
        private readonly ScoreRuleChain _scoreRuleChain;

        public Player Player1 { get; }

        public Player Player2 { get; }

        public GameState(string player1Name, string player2Name)
            : this(player1Name, player2Name, new ScoreRuleChain(new IScoreRule[]
            {
                new ScoreRuleWin(),
                new ScoreRuleEven(),
                new ScoreRuleAdvantage(),
                new ScoreRuleNormal()
            }))
            { }

        public GameState(string player1Name, string player2Name, ScoreRuleChain scoreRuleChain)
        {
            Player1 = new Player(player1Name);
            Player2 = new Player(player2Name);

            _scoreRuleChain = scoreRuleChain;
        }

        private Player FindPlayerByName(string playerName)
        {
            if (playerName == Player1.Name)
            {
                return Player1;
            }

            if (playerName == Player2.Name)
            {
                return Player2;
            }

            return null;
        }

        public string GetScore()
        {
            return _scoreRuleChain.GetScore(Player1, Player2);
        }

        public void WonPoint(string playerName)
        {
            FindPlayerByName(playerName).Points++;
        }
    }
}