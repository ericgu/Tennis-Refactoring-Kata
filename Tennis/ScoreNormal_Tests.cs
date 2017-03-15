using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoreNormalTests
    {
        [Test]
        public void when_I_call_Get_Score_with_a_2_2_score__it_returns_null()
        {
            Assert.IsNull(new ScoreNormal().ScoreDirect(new ScoringData(2, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_1_3_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Fifteen-Forty", new ScoreNormal().ScoreDirect(new ScoringData(1, 3, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_0_2_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Love-Thirty", new ScoreNormal().ScoreDirect(new ScoringData(0, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_7_6_score__it_returns_null()
        {
            Assert.IsNull(new ScoreNormal().ScoreDirect(new ScoringData(7, 6, "Fred", "Barney")));
        }
    }
}

