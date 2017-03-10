namespace Tennis
{
    class Score
    {
        public int Value { set; get; }

        public string ScoreWord
        {
            get { return Words[Value]; }
        }

        private static readonly string[] Words = {"Love", "Fifteen", "Thirty", "Forty"};
    }
}