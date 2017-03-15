namespace Tennis
{
    public abstract class ScoreBase
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            string tempScore = ScoreDirect(scoringData);
            score = tempScore ?? score;

            ScoreReady?.Invoke(scoringData, score);
        }

        public abstract string ScoreDirect(ScoringData scoringData);
    }
}