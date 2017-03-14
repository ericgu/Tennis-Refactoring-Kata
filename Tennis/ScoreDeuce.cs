namespace Tennis
{
    internal class ScoreDeuce: ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            string score = null;
            if (scoringData.IsDeuce)
            {
                score = "Deuce";
            }

            return score;
        }
    }
}