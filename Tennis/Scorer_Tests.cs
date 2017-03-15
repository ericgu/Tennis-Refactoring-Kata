using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tennis
{
    [TestFixture]
    public class ScorerTests
    {
        [Test]
        public void when_I_call_GetScore_on_a_single_class_that_returns_a_string__the_string_is_passed_through_the_event()
        {
            Scorer scorer = new Scorer(new ScoreReturnsScore());

            string result = null;
            scorer.ScoreReady += (data, score) => { result = score; };
            scorer.Score(new ScoringData(1, 2, "red", "blue"));
            Assert.AreEqual("Pebbles", result);
        }

        [Test]
        public void when_I_call_GetScore_on_a_two_classes_where_the_second_returns_a_string__the_string_is_passed_through_the_event()
        {
            Scorer scorer = new Scorer(new ScoreReturnsNull(), new ScoreReturnsScore());

            string result = null;
            scorer.ScoreReady += (data, score) => { result = score; };
            scorer.Score(new ScoringData(1, 2, "red", "blue"));
            Assert.AreEqual("Pebbles", result);
        }


        [Test]
        public void when_I_call_GetScore_on_a_two_classes_where_the_first_returns_a_string_and_the_second_returns_null__the_string_is_passed_through_the_event()
        {
            Scorer scorer = new Scorer(new ScoreReturnsScore(), new ScoreReturnsNull());

            string result = null;
            scorer.ScoreReady += (data, score) => { result = score; };
            scorer.Score(new ScoringData(1, 2, "red", "blue"));
            Assert.AreEqual("Pebbles", result);
        }
    }
}

