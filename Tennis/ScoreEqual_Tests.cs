using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoreEqualTests
    {
        [Test]
        public void when_I_call_Get_Score_with_a_2_2_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Thirty-All", new ScoreEqual().ScoreDirect(new ScoringData(2, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_3_3_score__it_returns_null()
        {
            Assert.IsNull(new ScoreEqual().ScoreDirect(new ScoringData(3, 3, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_3_1_score__it_returns_null()
        {
            Assert.IsNull(new ScoreEqual().ScoreDirect(new ScoringData(3, 1, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_0_0_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Love-All", new ScoreEqual().ScoreDirect(new ScoringData(0, 0, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_1_1_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Fifteen-All", new ScoreEqual().ScoreDirect(new ScoringData(1, 1, "Fred", "Barney")));
        }

    }
}

