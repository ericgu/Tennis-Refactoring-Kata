using System.Collections.Generic;
using System.Linq;

namespace Tennis
{
    internal class Scorer
    {
        private readonly List<ScoreBase> _scorers;

        public Scorer(params ScoreBase[] scoreBases)
        {
            _scorers = scoreBases.ToList();
        }

        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            for (int i = 0; i < _scorers.Count - 1; i++)
            {
                _scorers[i].ScoreReady += _scorers[i + 1].Score;
            }

            _scorers[_scorers.Count - 1].ScoreReady += (data, scoreParam) => ScoreReady?.Invoke(data, scoreParam);

            _scorers[0].Score(scoringData, null);
        }
    }
}