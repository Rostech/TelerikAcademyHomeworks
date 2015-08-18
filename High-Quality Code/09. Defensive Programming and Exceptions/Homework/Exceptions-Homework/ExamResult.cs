using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if(value < 0)
            {
                throw new ArgumentException(String.Format("Grade can't be less than 0! value: ({0})", value));
            }

            this.grade = value;
        }
    }

    public int MinGrade 
    {
        get
        {
            return this.minGrade;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(String.Format("MinGrade can't be less than 0! value: ({0})", value));
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade 
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value < this.MinGrade)
            {
                throw new ArgumentException(String.Format("MaxGrade can't be less or equal to MinGrade! value: ({0})", value));
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (value == null || value == "")
            {
                throw new ArgumentException(String.Format("Comments can't be null or empty string! value: ({0})", value));
            }

            this.comments = value;
        }
    }
}
