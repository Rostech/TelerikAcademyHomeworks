using System;

public class SimpleMathExam : Exam
{
    private const int MinScore = 2;
    private const int MaxScore = 6;

    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    { 
        get 
        {
            return this.problemSolved;
        } 
        private set
        {
            if (value < 0)
            {
                value = 0;
            }
            else if (value > 10)
            {
                value = 10;
            }

            this.problemSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, MinScore, MaxScore, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, MinScore, MaxScore, "Average result: nothing done.");
        }
        else if (ProblemsSolved >= 2)
        {
            return new ExamResult(6, MinScore, MaxScore, "Average result: nothing done.");
        }

        return new ExamResult(0, 0, 0, "The problems solved are not the right count!");
    }
}
