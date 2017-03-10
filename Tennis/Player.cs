namespace Tennis
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { set; get; }

        public int Points { get; set; }
    }
}

