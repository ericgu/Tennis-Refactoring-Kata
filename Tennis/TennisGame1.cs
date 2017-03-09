using System.Data.SqlClient;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
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
            string score = "";
            var tempScore = 0;
            string score1;
            score1 = EvenScore();
            if (score1 != null)
            {
                return score1;
            }

            score1 = ScoreAdvantage();
            if (score1 != null)
            {
                return score1;
            }

            score1 = ScoreWin();
            if (score1 != null)
            {
                return score1;
            }

            return NormalScore(score);
        }

        private string NormalScore(string score)
        {
            return GetScoreWord(m_score1) + "-" + GetScoreWord(m_score2);
        }

        private static string GetScoreWord(int tempScore)
        {
            string word = string.Empty;
            switch (tempScore)
            {
                case 0:
                    word = "Love";
                    break;
                case 1:
                    word = "Fifteen";
                    break;
                case 2:
                    word = "Thirty";
                    break;
                case 3:
                    word = "Forty";
                    break;
            }
            return word;
        }

        private string ScoreWin()
        {
            string score;
            if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;
                if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";

                return score;
            }
            return null;
        }

        private string ScoreAdvantage()
        {
            string score = null;
            if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";

                return score;
            }
            return null;
        }

        private string EvenScore()
        {
            if (m_score1 == m_score2)
            {
                if (m_score1 == 3)
                {
                    return "Deuce";
                }

                return GetScoreWord(m_score1) + "-All";
            }

            return null;
        }
    }
}

