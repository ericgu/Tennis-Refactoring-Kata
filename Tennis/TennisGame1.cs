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
                () => new ScoreRuleEven().Evaluate(m_score2, m_score1),
                () => new ScoreRuleAdvantage().Evaluate(m_score2, m_score1),
                () => new ScoreRuleWin().Evaluate(m_score2, m_score1),
                () => new ScoreRuleNormal().Evaluate(m_score2, m_score1));
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
    }
}

