using System;
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
            return GetScoreFromRules(
                () => ScoreRuleEven(m_score2, m_score1),
                () => ScoreRuleAdvantage(m_score2, m_score1),
                () => ScoreRuleWin(m_score2, m_score1),
                () => ScoreRuleNormal(m_score2, m_score1));
        }

        public string GetScoreFromRules(params Func<string>[] rules)
        {
            foreach (Func<string> rule in rules)
            {
                string score = rule();
                if (score != null)
                {
                    return score;
                }
            }

            return "Score Error";
        }

        private static string ScoreRuleNormal(int mScore2, int mScore1)
        {
            return ScoreWords.GetScoreWord(mScore1) + "-" + ScoreWords.GetScoreWord(mScore2);
        }

        private static string ScoreRuleWin(int mScore2, int mScore1)
        {
            string score;
            if (mScore1 >= 4 || mScore2 >= 4)
            {
                var minusResult = mScore1 - mScore2;
                if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";

                return score;
            }
            return null;
        }

        private static string ScoreRuleAdvantage(int mScore2, int mScore1)
        {
            string score = null;
            if (mScore1 >= 4 || mScore2 >= 4)
            {
                var minusResult = mScore1 - mScore2;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";

                return score;
            }
            return null;
        }

        private static string ScoreRuleEven(int mScore2, int mScore1)
        {
            if (mScore1 == mScore2)
            {
                if (mScore1 == 3)
                {
                    return "Deuce";
                }

                return ScoreWords.GetScoreWord(mScore1) + "-All";
            }

            return null;
        }
    }
}

