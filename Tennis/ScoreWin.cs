namespace Tennis
{
    internal class ScoreWin: ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            string score = null;
            if (scoringData.EitherPlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage >= 2)
                {
                    score = "Win for " + scoringData.Player1Name;
                }
                else if (scoringData.Player2PointAdvantage >= 2)
                {
                    score = "Win for " + scoringData.Player2Name;
                }
            }
            return score;
        }
    }
}