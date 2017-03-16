using System;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class ScoringDataTests
    {
        [Test]
        public void when_I_call_Player1PointsName_and_Player2PointsName__they_return_the_right_names()
        {
            Assert.AreEqual("Love", new ScoringData(0, 1, null, null).Player1PointsName);
            Assert.AreEqual("Fifteen", new ScoringData(0, 1, null, null).Player2PointsName);
            Assert.AreEqual("Thirty", new ScoringData(2, 3, null, null).Player1PointsName);
            Assert.AreEqual("Forty", new ScoringData(2, 3, null, null).Player2PointsName);
        }

        [Test]
        public void when_I_call_Player1Name_and_Player2Name__they_return_the_right_names()
        {
            Assert.AreEqual("Fred", new ScoringData(0, 1, "Fred", "Barney").Player1Name);
            Assert.AreEqual("Barney", new ScoringData(0, 1, "Fred", "Barney").Player2Name);
        }


        [Test]
        public void when_I_call_EitherPlayerScoredFourOrHigher_with_both_players_under_four__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(3, 3, "Fred", "Barney").EitherPlayerScoredFourOrHigher);
        }

        [Test]
        public void when_I_call_EitherPlayerScoredFourOrHigher_with_player_one_four__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(4, 3, "Fred", "Barney").EitherPlayerScoredFourOrHigher);
        }

        [Test]
        public void when_I_call_EitherPlayerScoredFourOrHigher_with_player_two_four__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(3, 4, "Fred", "Barney").EitherPlayerScoredFourOrHigher);
        }

        [Test]
        public void when_I_call_EitherPlayerScoredFourOrHigher_with_player_one_more_than_four__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(5, 3, "Fred", "Barney").EitherPlayerScoredFourOrHigher);
        }

        [Test]
        public void when_I_call_EitherPlayerScoredFourOrHigher_with_player_two_more_than_four__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(3, 5, "Fred", "Barney").EitherPlayerScoredFourOrHigher);
        }

        [Test]
        public void when_I_call_Player1PointAdvantage_with_a_tied_score__it_returns_zero()
        {
            Assert.AreEqual(0, new ScoringData(3, 3, "Fred", "Barney").Player1PointAdvantage);
        }

        [Test]
        public void when_I_call_Player1PointAdvantage_with_Player_1_ahead_by_two__it_returns_two()
        {
            Assert.AreEqual(2, new ScoringData(5, 3, "Fred", "Barney").Player1PointAdvantage);
        }

        [Test]
        public void when_I_call_Player1PointAdvantage_with_Player_1_behind_by_1__it_returns_zero()
        {
            Assert.AreEqual(0, new ScoringData(2, 3, "Fred", "Barney").Player1PointAdvantage);
        }

        [Test]
        public void when_I_call_Player2PointAdvantage_with_a_tied_score__it_returns_zero()
        {
            Assert.AreEqual(0, new ScoringData(3, 3, "Fred", "Barney").Player2PointAdvantage);
        }

        [Test]
        public void when_I_call_Player2PointAdvantage_with_Player_2_ahead_by_two__it_returns_two()
        {
            Assert.AreEqual(2, new ScoringData(3, 5, "Fred", "Barney").Player2PointAdvantage);
        }

        [Test]
        public void when_I_call_Player2PointAdvantage_with_Player_2_behind_by_1__it_returns_zero()
        {
            Assert.AreEqual(0, new ScoringData(2, 1, "Fred", "Barney").Player2PointAdvantage);
        }

        [Test]
        public void when_I_call_IsDeuce_with_a_non_tied_score__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(3, 5, "Fred", "Barney").IsDeuce);
        }

        [Test]
        public void when_I_call_IsDeuce_with_a_2_2_score__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(2, 2, "Fred", "Barney").IsDeuce);
        }

        [Test]
        public void when_I_call_IsDeuce_with_a_3_3_score__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(3, 3, "Fred", "Barney").IsDeuce);
        }

        [Test]
        public void when_I_call_IsDeuce_with_a_10_10_score__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(10, 10, "Fred", "Barney").IsDeuce);
        }

        [Test]
        public void when_I_call_IsScoringNormal_with_both_players_under_four_and_tied__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(3, 3, "Fred", "Barney").IsScoringNormal);
        }

        [Test]
        public void when_I_call_IsScoringNormal_with_both_players_under_four_and_not_tied__it_returns_true()
        {
            Assert.IsTrue(new ScoringData(2, 3, "Fred", "Barney").IsScoringNormal);
        }

        [Test]
        public void when_I_call_IsScoringNormal_with_score_4_4__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(4, 4, "Fred", "Barney").IsScoringNormal);
        }

        [Test]
        public void when_I_call_IsScoringNormal_with_score_4_5__it_returns_false()
        {
            Assert.IsFalse(new ScoringData(4, 5, "Fred", "Barney").IsScoringNormal);
        }

    }
}

