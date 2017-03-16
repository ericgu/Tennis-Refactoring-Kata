using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoringRulesTests
    {
        // ScoreAdvantage

        [Test]
        public void when_I_call_ScoreAdvantage_with_a_normal_score__it_passes_null()
        {
            Assert.IsNull(new ScoringData(1, 2, "Fred", "Barney").ScoreAdvantage().Score);
        }

        [Test]
        public void when_I_call_ScoreAdvantage_with_a_winning_score__it_passes_null()
        {
            Assert.IsNull(new ScoringData(4, 2, "Fred", "Barney").ScoreAdvantage().Score);
        }

        [Test]
        public void when_I_call_ScoreAdvantage_with_a_player1_advantage__it_passes_the_proper_score()
        {
            Assert.AreEqual("Advantage Fred", new ScoringData(5, 4, "Fred", "Barney").ScoreAdvantage().Score);
        }

        [Test]
        public void when_I_call_ScoreAdvantage_with_a_player2_advantage__it_passes_the_proper_score()
        {
            Assert.AreEqual("Advantage Barney", new ScoringData(3, 4, "Fred", "Barney").ScoreAdvantage().Score);
        }

        // ScoreDeuce

        public void when_I_call_ScoreDeuce_with_a_normal_tied_score__it_passes_null()
        {
            Assert.IsNull(new ScoringData(2, 2, "Fred", "Barney").ScoreDeuce().Score);
        }

        [Test]
        public void when_I_call_ScoreDeuce_with_a_3_3_score__it_returns_deuce()
        {
            Assert.AreEqual("Deuce", new ScoringData(3, 3, "Fred", "Barney").ScoreDeuce().Score);
        }

        [Test]
        public void when_I_call_ScoreDeuce_with_a_5_6_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(5, 6, "Fred", "Barney").ScoreDeuce().Score);
        }

        [Test]
        public void when_I_call_ScoreDeuce_with_a_7_7_score__it_returns_deuce()
        {
            Assert.AreEqual("Deuce", new ScoringData(7, 7, "Fred", "Barney").ScoreDeuce().Score);
        }

        // Score Equal

        [Test]
        public void when_I_call_ScoreEqual_with_a_2_2_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Thirty-All", new ScoringData(2, 2, "Fred", "Barney").ScoreEqual().Score);
        }

        [Test]
        public void when_I_call_ScoreEqual_with_a_3_3_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(3, 3, "Fred", "Barney").ScoreEqual().Score);
        }

        [Test]
        public void when_I_call_ScoreEqual_with_a_3_1_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(3, 1, "Fred", "Barney").ScoreEqual().Score);
        }

        [Test]
        public void when_I_call_ScoreEqual_with_a_0_0_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Love-All", new ScoringData(0, 0, "Fred", "Barney").ScoreEqual().Score);
        }

        [Test]
        public void when_I_call_ScoreEqual_with_a_1_1_score__it_returns_the_correct_score()
        {
            Assert.AreEqual("Fifteen-All", new ScoringData(1, 1, "Fred", "Barney").ScoreEqual().Score);
        }

        // ScoreNormal
        [Test]
        public void when_I_call_ScoreNormal_with_a_2_2_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(2, 2, "Fred", "Barney").ScoreNormal().Score);
        }

        [Test]
        public void when_I_call_ScoreNormal_with_a_1_3_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Fifteen-Forty", new ScoringData(1, 3, "Fred", "Barney").ScoreNormal().Score);
        }

        [Test]
        public void when_I_call_ScoreNormal_with_a_0_2_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Love-Thirty", new ScoringData(0, 2, "Fred", "Barney").ScoreNormal().Score);
        }

        [Test]
        public void when_I_call_ScoreNormal_with_a_7_6_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(7, 6, "Fred", "Barney").ScoreNormal().Score);
        }

        // Score Win

        [Test]
        public void when_I_call_ScoreWin_with_a_normal_tied_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(2, 2, "Fred", "Barney").ScoreWin().Score);
        }

        [Test]
        public void when_I_call_ScoreWin_with_a_3_3_score__it_returns_null()
        {
            Assert.IsNull(new ScoringData(3, 3, "Fred", "Barney").ScoreWin().Score);
        }

        [Test]
        public void when_I_call_ScoreWin_with_a_5_7_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Win for Barney", new ScoringData(5, 7, "Fred", "Barney").ScoreWin().Score);
        }

        [Test]
        public void when_I_call_ScoreWin_with_a_4_2_score__it_returns_the_proper_score()
        {
            Assert.AreEqual("Win for Fred", new ScoringData(4, 2, "Fred", "Barney").ScoreWin().Score);
        }

    }
}

