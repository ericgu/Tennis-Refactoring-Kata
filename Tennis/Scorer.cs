namespace Tennis
{
    internal class Scorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            var scoreEqual = new ScoreEqual();
            var scoreAdvantage = new ScoreAdvantage();
            var scoreWin = new ScoreWin();
            var scoreNormal = new ScoreNormal();

            scoreEqual.ScoreReady += scoreAdvantage.Score;
            scoreAdvantage.ScoreReady += scoreWin.Score;
            scoreWin.ScoreReady += scoreNormal.Score;
            scoreNormal.ScoreReady += (data, scoreParam) => ScoreReady?.Invoke(data, scoreParam); 

            scoreEqual.Score(scoringData, null);
        }
    }
}