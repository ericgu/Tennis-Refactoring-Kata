namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly GameState _gameState;

        public TennisGame1(string player1Name, string player2Name)
        {
            _gameState = new GameState(player1Name, player2Name);
        }

        public void WonPoint(string playerName)
        {
            _gameState.WonPoint(playerName);
        }

        public string GetScore()
        {
            return _gameState.GetScore();
        }
    }
}

