using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoreDeuceTests
    {
        [Test]
        public void when_I_call_Get_Score_with_a_normal_tied_score__it_passes_null()
        {
            Assert.IsNull(new ScoreDeuce().ScoreDirect(new ScoringData(2, 2, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_3_3_score__it_returns_deuce()
        {
            Assert.AreEqual("Deuce", new ScoreDeuce().ScoreDirect(new ScoringData(3, 3, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_5_6_score__it_returns_null()
        {
            Assert.IsNull(new ScoreDeuce().ScoreDirect(new ScoringData(5, 6, "Fred", "Barney")));
        }

        [Test]
        public void when_I_call_Get_Score_with_a_7_7_score__it_returns_deuce()
        {
            Assert.AreEqual("Deuce", new ScoreDeuce().ScoreDirect(new ScoringData(7, 7, "Fred", "Barney")));
        }
    }
}

