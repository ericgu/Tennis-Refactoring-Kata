namespace Tennis
{
    internal class ScoreAdvantage : ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            string score = null;

            if (scoringData.EitherPlayerScoredFourOrHigher)
            {
                if (scoringData.Player1PointAdvantage == 1)
                {
                    score = "Advantage " + scoringData.Player1Name;
                }
                else if (scoringData.Player2PointAdvantage == 1)
                {
                    score = "Advantage " + scoringData.Player2Name;
                }
            }
            return score;
        }
    }
}