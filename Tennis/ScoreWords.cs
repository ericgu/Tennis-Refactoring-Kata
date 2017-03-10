namespace Tennis
{
    internal static class ScoreWords
    {
        private static readonly string[] Words = {"Love", "Fifteen", "Thirty", "Forty"};

        public static string GetScoreWord(int tempScore)
        {
            return Words[tempScore];
        }
    }
}