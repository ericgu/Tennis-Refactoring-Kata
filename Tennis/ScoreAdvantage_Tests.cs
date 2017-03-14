using NUnit.Framework;

namespace Tennis
{

    [TestFixture]
    public class ScoreAdvantageTests
    {
        [Test]
        public void when_I_call_Get_Score_with_a_normal_score__it_passes_null()
        {
            Assert.IsNull(new ScoreAdvantage().ScoreDirect(new ScoringData(1, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_winning_score__it_passes_null()
        {
            Assert.IsNull(new ScoreAdvantage().ScoreDirect(new ScoringData(4, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_player1_advantage__it_passes_the_proper_score()
        {
            Assert.AreEqual("Advantage Fred", new ScoreAdvantage().ScoreDirect(new ScoringData(4, 3, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_player2_advantage__it_passes_the_proper_score()
        {
            Assert.AreEqual("Advantage Barney", new ScoreAdvantage().ScoreDirect(new ScoringData(3, 4, "Fred", "Barney")));
        }
    }
}

