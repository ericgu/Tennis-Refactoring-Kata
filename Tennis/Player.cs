namespace Tennis
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
            Score = new Score();
        }

        public string Name { set; get; }

        public Score Score { get; }
    }
}

