namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly ScoreRuleChain _scoreRuleChain;
        private readonly Player _player1;
        private readonly Player _player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);

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
            if (playerName == _player1.Name)
            {
                currentPlayer = _player1;
            }
            else
            {
                currentPlayer = _player2;
            }
            return currentPlayer;
        }


        public string GetScore()
        {
            return _scoreRuleChain.Evaluate(_player1, _player2);
        }
    }
}

