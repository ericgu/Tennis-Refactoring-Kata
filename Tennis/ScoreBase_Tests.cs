using System;
using NUnit.Framework;

namespace Tennis
{
    public class ScoreReturnsScore : ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            return "Pebbles";
        }
    }

    public class ScoreReturnsNull : ScoreBase
    {
        public override string ScoreDirect(ScoringData scoringData)
        {
            return null;
        }
    }

    [TestFixture]
    public class ScoreBaseTests
    {
        [Test]
        public void when_I_call_Score_on_a_class_that_returns_a_string__the_string_is_passed_through_the_event()
        {
            string result = null;
            ScoreReturnsScore scoreReturnsScore = new ScoreReturnsScore();
            scoreReturnsScore.ScoreReady += (data, score) => { result = score; };
            scoreReturnsScore.Score(new ScoringData(1, 2, "red", "blue"), null);
            Assert.AreEqual("Pebbles", result);
        }

        [Test]
        public void when_I_call_Score_on_a_class_that_returns_null__the_previous_string_is_passed_through_the_event()
        {
            string result = null;
            ScoreReturnsNull scoreReturnsNull = new ScoreReturnsNull();
            scoreReturnsNull.ScoreReady += (data, score) => { result = score; };
            scoreReturnsNull.Score(new ScoringData(1, 2, "red", "blue"), "Wilma");
            Assert.AreEqual("Wilma", result);
        }

    }
}

