namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1;
        private int _mScore2;
        private readonly string _player1Name;
        private string _player2Name;
        private readonly ScoreRuleChain _scoreRuleChain;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;

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
            if (playerName == _player1Name)
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        public string GetScore()
        {
            return _scoreRuleChain.Evaluate(_mScore2, _mScore1);
        }
    }
}

