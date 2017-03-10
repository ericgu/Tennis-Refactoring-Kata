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
                new ScoreRuleAdvantage(player1Name, player2Name),
                new ScoreRuleWin(player1Name, player2Name),
                new ScoreRuleNormal()
            });
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1.Player1Name)
                Player.WonPoint(_player1);
            else
                Player.WonPoint(_player2);
        }


        public string GetScore()
        {
            return _scoreRuleChain.Evaluate(_player1, _player2);
        }
    }
}

