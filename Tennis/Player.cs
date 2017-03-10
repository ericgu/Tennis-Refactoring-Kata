namespace Tennis
{
    class Player
    {
        private int _score;
        private string _player1Name;

        public Player(string player1Name)
        {
            _player1Name = player1Name;
        }

        public int Score
        {
            set { _score = value; }
            get { return _score; }
        }

        public string Player1Name
        {
            set { _player1Name = value; }
            get { return _player1Name; }
        }

        public static int WonPoint(Player player1)
        {
            return player1.Score += 1;
        }
    }
}

