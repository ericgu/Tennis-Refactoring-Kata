namespace Tennis
{
    internal static class ScoreWords
    {
        public static string GetScoreWord(int value)
        {
            return Words[value];
        }

        private static readonly string[] Words = {"Love", "Fifteen", "Thirty", "Forty"};
    }
}