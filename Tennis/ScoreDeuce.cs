namespace Tennis
{
    internal class ScoreDeuce
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData, string score)
        {
            if (scoringData.IsDeuce)
            {
                score = "Deuce";
            }

            ScoreReady?.Invoke(scoringData, score);
        }
    }
}