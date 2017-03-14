namespace Tennis
{
    internal class ScoreEqual: ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            string score = null;
            if (!scoringData.IsDeuce && scoringData.IsScoreEqual)
            {
                score = scoringData.Player1PointsName + "-All";
            }
            return score;
        }
    }
}