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

        public int WonPoint()
        {
            return Score += 1;
        }
    }
}

