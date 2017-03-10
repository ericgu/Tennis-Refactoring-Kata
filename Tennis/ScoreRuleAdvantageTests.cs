using NUnit.Framework.Constraints;
using NUnit.Framework;
namespace Tennis
{
    [TestFixture]
    internal class ScoreRuleAdvantageTests
    {
        [Test]
        public void when_I_call_Evaluate_with_a_normal_score__it_returns_null()
        {
            Assert.IsNull(Setup(3, 3));
        }

        [Test]
        public void when_I_call_Evaluate_with_a_winning_score__it_returns_null()
        {
            Assert.IsNull(Setup(5, 3));
        }

        [Test]
        public void when_I_call_Evaluate_with_an_advantage__it_returns_correctly()
        {
            Assert.AreEqual("Advantage Fred", Setup(5, 4));
        }

        [Test]
        public void when_I_call_Evaluate_with_an_advantage2__it_returns_correctly()
        {
            Assert.AreEqual("Advantage Barney", Setup(4, 5));
        }

        private static string Setup(int player1Score, int player2Score)
        {
            GameState gameState = new GameState("Fred", "Barney");

            gameState.Player1.Score.Value = player1Score;
            gameState.Player2.Score.Value = player2Score;

            return new ScoreRuleAdvantage().Evaluate(gameState);
        }
    }
}