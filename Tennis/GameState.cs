namespace Tennis
{
    class GameState
    {
        public Player Player1 { set; get; }

        public Player Player2 { set; get; }

        public GameState(string player1Name, string player2Name)
        {
            Player1 = new Player(player1Name);
            Player2 = new Player(player2Name);
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