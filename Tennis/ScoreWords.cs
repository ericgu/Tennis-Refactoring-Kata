using System;

static internal class ScoreWords
{
    public static string GetScoreWord(int tempScore)
    {
        string word = String.Empty;
        switch (tempScore)
        {
            case 0:
                word = "Love";
                break;
            case 1:
                word = "Fifteen";
                break;
            case 2:
                word = "Thirty";
                break;
            case 3:
                word = "Forty";
                break;
        }
        return word;
    }
}