namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        public int m_score1;
        public int m_score2;

        public TennisGame1(string player1Name, string player2Name)
        {
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            return Scorer.Scores[m_score1, m_score2];
        }
    }
}

