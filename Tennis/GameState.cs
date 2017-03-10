namespace Tennis
{
    class GameState
    {
        public GameState(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Player Player1 { set; get; }

        public Player Player2 { set; get; }

        public GameState(string player1Name, string player2Name)
            : this(new Player(player1Name), new Player(player2Name) )
        {
            
        }

        public Player FindPlayerByName(string playerName)
        {
            Player currentPlayer;
            if (playerName == Player1.Name)
            {
                currentPlayer = Player1;
            }
            else
            {
                currentPlayer = Player2;
            }
            return currentPlayer;
        }
    }
}