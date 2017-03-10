namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly ScoreRuleChain _scoreRuleChain;
        private readonly GameState _gameState;

        public TennisGame1(string player1Name, string player2Name)
        {
            _gameState = new GameState(new Player(player1Name), new Player(player2Name));


            _scoreRuleChain = new ScoreRuleChain(new IScoreRule[]
            {
                new ScoreRuleEven(),
                new ScoreRuleAdvantage(),
                new ScoreRuleWin(),
                new ScoreRuleNormal()
            });
        }

        public void WonPoint(string playerName)
        {
            var currentPlayer = FindPlayerByName(playerName);

            currentPlayer.WonPoint();
        }

        private Player FindPlayerByName(string playerName)
        {
            Player currentPlayer;
            if (playerName == _gameState.Player1.Name)
            {
                currentPlayer = _gameState.Player1;
            }
            else
            {
                currentPlayer = _gameState.Player2;
            }
            return currentPlayer;
        }


        public string GetScore()
        {
            return _scoreRuleChain.Evaluate(_gameState.Player1, _gameState.Player2);
        }
    }
}

