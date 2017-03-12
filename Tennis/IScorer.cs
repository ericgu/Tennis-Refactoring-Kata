namespace Tennis
{
    internal interface IScorer
    {
        event ScoreHandler ScoreReady;
        void Score(ScoringData scoringData);
    }
}