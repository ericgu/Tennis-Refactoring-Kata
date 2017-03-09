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
                new ScoreRuleEven().Evaluate,
                new ScoreRuleAdvantage().Evaluate,
                new ScoreRuleWin().Evaluate,
                new ScoreRuleNormal().Evaluate);
        }

        public string GetScoreFromRules(params Func<int, int, string>[] rules)
        {
            foreach (Func<int, int, string> rule in rules)
            {
                string score = rule(m_score2, m_score1);
                if (score != null)
                {
                    return score;
                }
            }

            return "Score Error";
        }
    }
}

