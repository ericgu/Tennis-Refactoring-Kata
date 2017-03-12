namespace Tennis
{
    internal class Scorer
    {
        public event ScoreHandler ScoreReady;

        public void Score(ScoringData scoringData)
        {
            var scoreDeuce = new ScoreDeuce();
            var scoreEqual = new ScoreEqual();
            var scoreAdvantage = new ScoreAdvantage();
            var scoreWin = new ScoreWin();
            var scoreNormal = new ScoreNormal();

            scoreDeuce.ScoreReady += scoreEqual.Score;
            scoreEqual.ScoreReady += scoreAdvantage.Score;
            scoreAdvantage.ScoreReady += scoreWin.Score;
            scoreWin.ScoreReady += scoreNormal.Score;
            scoreNormal.ScoreReady += (data, scoreParam) => ScoreReady?.Invoke(data, scoreParam); 

            scoreDeuce.Score(scoringData, null);
        }
    }
}