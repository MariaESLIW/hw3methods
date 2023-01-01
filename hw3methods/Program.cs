internal class Program
{
    static void Main(string[] args)
    {
        int[] scores1 = { 10, 8, 7, 7, 6, 6, 7, 3 };

        double average1 = GetAverageScore(scores1);
        int maxScore1 = GetMaxScore(scores1);
        int minScore1 = GetMinScore(scores1);

        Console.WriteLine("\nAverage score1: " + average1);
        Console.WriteLine("Maximum score1: " + maxScore1);
        Console.WriteLine("Minimum score1: " + minScore1);

        int[] scores2 = { 9, 2, 3, 0, 6, 6, 7, 5 };

        double average2 = GetAverageScore(scores2);
        int maxScore2 = GetMaxScore(scores2);
        int minScore2 = GetMinScore(scores2);

        Console.WriteLine("\nAverage score2: " + average2);
        Console.WriteLine("Maximum score2: " + maxScore2);
        Console.WriteLine("Minimum score2: " + minScore2);

        int[] scores3 = { 2, 2, 3, 4, 6, 6, 3, 5 };

        double average3 = GetAverageScore(scores3);
        int maxScore3 = GetMaxScore(scores3);
        int minScore3 = GetMinScore(scores3);

        Console.WriteLine("\nAverage score3: " + average3);
        Console.WriteLine("Maximum score3: " + maxScore3);
        Console.WriteLine("Minimum score3: " + minScore3);

        int[] scores4 = { 2, 2, 9, 8, 6, 6, 7, 5 };

        double average4 = GetAverageScore(scores4);
        int maxScore4 = GetMaxScore(scores4);
        int minScore4 = GetMinScore(scores4);

        Console.WriteLine("\nAverage score4: " + average4);
        Console.WriteLine("Maximum score4: " + maxScore4);
        Console.WriteLine("Minimum score4: " + minScore4);

        int[] scores5 = { 0, 1, 2, 3, 4, 10, 7, 5 };

        double average5 = GetAverageScore(scores5);
        int maxScore5 = GetMaxScore(scores5);
        int minScore5 = GetMinScore(scores5);

        Console.WriteLine("\nAverage score5: " + average5);
        Console.WriteLine("Maximum score5: " + maxScore5);
        Console.WriteLine("Minimum score5: " + minScore5);


    }

    static double GetAverageScore(int[] scores)
    {
        double average = 0.0;
        int sumMarks = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            sumMarks = sumMarks + scores[i];
        }
        average = (double)sumMarks / scores.Length;
        return average;
    }

    static int GetMaxScore(int[] scores)
    {
        int maxScore = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            if (maxScore < scores[i])
            {
                maxScore = scores[i];
            }
        }
        return maxScore;
    }

    static int GetMinScore(int[] scores)
    {
        int minScore = 10;
        for (int i = 0; i < scores.Length; i++)
        {
            if (minScore > scores[i])
            {
                minScore = scores[i];
            }
        }
        return minScore;
    }
}



