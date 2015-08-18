using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(String.Format("The score can't be less than 0 orr bigger than 100! value: {0}", value));
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}

