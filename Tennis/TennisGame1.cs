using System.Threading;
using System.Threading.Tasks;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1 = 0;
        private int _mScore2 = 0;
        private string _player1Name;
        private string _player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1Name)
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        //private ManualResetEvent _dataReady = new ManualResetEvent(false);
        private string _score;

        public string GetScore()
        {
            Task task = new Task(() => GetScoreInternal(this, _mScore1, _mScore2, this._player1Name, this._player2Name));
            task.Start();
            task.Wait();

            return _score;
        }

        private static void GetScoreInternal(TennisGame1 tennisGame1, int points1, int points2, string player1Name, string player2Name)
        {
            string score = "";
            if (points1 == points2)
            {
                switch (points1)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;
                }
            }
            else if (points1 >= 4 || points2 >= 4)
            {
                var minusResult = points1 - points2;
                if (minusResult == 1) score = "Advantage " + player1Name;
                else if (minusResult == -1) score = "Advantage " + player2Name;
                else if (minusResult >= 2) score = "Win for " + player1Name;
                else score = "Win for " + player2Name;
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    int tempScore;
                    if (i == 1) tempScore = points1;
                    else
                    {
                        score += "-";
                        tempScore = points2;
                    }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            tennisGame1._score = score;
        }
    }
}

