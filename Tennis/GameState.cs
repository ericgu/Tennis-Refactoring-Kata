namespace Tennis
{
    class GameState
    {
        private readonly ScoreRuleChain _scoreRuleChain;

        public Player Player1 { set; get; }

        public Player Player2 { set; get; }

        public GameState(string player1Name, string player2Name)
        {
            Player1 = new Player(player1Name);
            Player2 = new Player(player2Name);

            _scoreRuleChain = new ScoreRuleChain(new IScoreRule[]
            {
                new ScoreRuleWin(),
                new ScoreRuleEven(),
                new ScoreRuleAdvantage(),
                new ScoreRuleNormal()
            });
        }

        private Player FindPlayerByName(string playerName)
        {
            if (playerName == Player1.Name)
            {
                return Player1;
            }
            else if (playerName == Player2.Name)
            {
                return Player2;
            }

            return null;
        }

        public string GetScore()
        {
            return _scoreRuleChain.Evaluate(Player1, Player2);
        }

        public void WonPoint(string playerName)
        {
            FindPlayerByName(playerName).Score++;
        }
    }
}