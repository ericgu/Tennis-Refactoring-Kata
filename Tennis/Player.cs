namespace Tennis
{
    class Player
    {
        private int _mScore1;
        private string _player1Name;

        public Player(string player1Name)
        {
            _player1Name = player1Name;
        }

        public int MScore1
        {
            set { _mScore1 = value; }
            get { return _mScore1; }
        }

        public string Player1Name
        {
            set { _player1Name = value; }
            get { return _player1Name; }
        }
    }
}

