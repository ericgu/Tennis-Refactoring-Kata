using System.Collections.Generic;
using NUnit.Framework;

namespace Tennis
{
    internal class Scorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            List<ScoreBase> scorers = new List<ScoreBase>();
            scorers.Add(new ScoreDeuce());
            scorers.Add(new ScoreEqual());
            scorers.Add(new ScoreAdvantage());
            scorers.Add(new ScoreWin());
            scorers.Add(new ScoreNormal());

            for (int i = 0; i < scorers.Count - 1; i++)
            {
                scorers[i].ScoreReady += scorers[i + 1].Score;
            }

            scorers[scorers.Count - 1].ScoreReady += (data, scoreParam) => ScoreReady?.Invoke(data, scoreParam);

            scorers[0].Score(scoringData, null);
        }
    }
}