using System.Collections.Generic;

namespace Tennis
{
    internal class Scorer
    {
        private readonly List<ScoreBase> _scorers;

        public Scorer(List<ScoreBase> scoreBases)
        {
            _scorers = scoreBases;
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