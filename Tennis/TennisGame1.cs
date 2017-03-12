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
        public string _score;

        public string GetScore()
        {
            Task task = new Task(() => new Scorer().GetScoreInternal(_mScore1, _mScore2, this._player1Name, this._player2Name));
            task.Start();
            task.Wait();

            return _score;
        }
    }
}

