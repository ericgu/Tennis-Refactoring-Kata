namespace Tennis
{
    class GameState
    {
        private Player _player1;
        private Player _player2;

        public GameState(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public Player Player1
        {
            set { _player1 = value; }
            get { return _player1; }
        }

        public Player Player2
        {
            set { _player2 = value; }
            get { return _player2; }
        }
    }
}