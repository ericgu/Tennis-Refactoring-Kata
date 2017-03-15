using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoreWinTests
    {
        [Test]
        public void when_I_call_Get_Score_with_a_normal_tied_score__it_returns_null()
        {
            Assert.IsNull(new ScoreWin().ScoreDirect(new ScoringData(2, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_3_3_score__it_returns_null()
        {
            Assert.IsNull(new ScoreWin().ScoreDirect(new ScoringData(3, 3, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_5_7_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Win for Barney", new ScoreWin().ScoreDirect(new ScoringData(5, 7, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_4_2_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Win for Fred", new ScoreWin().ScoreDirect(new ScoringData(4, 2, "Fred", "Barney")));
        }
    }
}

