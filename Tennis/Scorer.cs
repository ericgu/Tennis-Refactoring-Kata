namespace Tennis
{
    internal class Scorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            var scoreEqual = new ScoreEqual();
            var scoreAdvantageOrWin = new ScoreAdvantageOrWin();
            var scoreNormal = new ScoreNormal();

            scoreEqual.ScoreReady += scoreAdvantageOrWin.Score;
            scoreAdvantageOrWin.ScoreReady += scoreNormal.Score;
            scoreNormal.ScoreReady += (data, scoreParam) => ScoreReady?.Invoke(data, scoreParam); 

            scoreEqual.Score(scoringData, null);
        }
    }
}