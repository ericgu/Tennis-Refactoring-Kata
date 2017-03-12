namespace Tennis
{
    internal class ScoringData
    {
        public static string[] ScoreWorkds = { "Love", "Fifteen", "Thirty", "Forty" };

        public ScoringData(int points1, int points2, string player1Name, string player2Name)
        {
            Points1 = points1;
            Points2 = points2;
            Player1Name = player1Name;
            Player2Name = player2Name;
        }

        public int Points1 { get; }

        public int Points2 { get; }

        public string Player1Name { get; }

        public string Player2Name { get; }

        public bool OnePlayerScoredFourOrHigher
        {
            get { return Points1 >= 4 || Points2 >= 4; }
        }

        public bool ScoreEqual
        {
            get { return Points1 == Points2; }
        }

        public int Player1PointAdvantage
        {
            get {
                return GetPointsAdvantage(Points1, Points2);
            }
        }

        public int Player2PointAdvantage
        {
            get
            {
                return GetPointsAdvantage(Points2, Points1);
            }
        }


        private int GetPointsAdvantage(int playerPoints, int otherPlayerPoints)
        {
            if (playerPoints > otherPlayerPoints)
            {
                return playerPoints - otherPlayerPoints;
            }

            return 0;
        }

        public string Player1PointsName
        {
            get { return ScoreWorkds[Points1]; }
        }

        public string Player2PointsName
        {
            get { return ScoreWorkds[Points2]; }
        }

        public bool IsDeuce()
        {
            return ScoreEqual && Points1 >= 3;
        }
    }
}