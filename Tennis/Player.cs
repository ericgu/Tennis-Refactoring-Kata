namespace Tennis
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public int Score { set; get; }

        public string Name { set; get; }

        public void WonPoint()
        {
            Score++;
        }
    }
}

