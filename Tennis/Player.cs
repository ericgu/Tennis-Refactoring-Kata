namespace Tennis
{
    class Player
    {
        private int _score;
        private string _name;

        public Player(string name)
        {
            _name = name;
        }

        public int Score
        {
            set { _score = value; }
            get { return _score; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public static int WonPoint(Player player1)
        {
            return player1.Score += 1;
        }
    }
}

