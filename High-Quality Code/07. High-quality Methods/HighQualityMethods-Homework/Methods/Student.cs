namespace Methods
{
    using System;
    using System.Globalization;

    internal class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            string studentBirthdayFromText = this.DateFromText(this.OtherInfo, "born at "); ;
            string otherStudentBirthdayFromText = this.DateFromText(otherStudent.OtherInfo, "born at ");
            string dateFormat = "dd'.'MM'.'yyyy";

            DateTime studentBirthday = this.ConvertTextToDate(studentBirthdayFromText, dateFormat);
            DateTime otherStudentBirthday = this.ConvertTextToDate(otherStudentBirthdayFromText, dateFormat);
            return studentBirthday < otherStudentBirthday;
        }

        private DateTime ConvertTextToDate(string text, string dateFormat)
        {
            try
            {
                DateTime date = DateTime.ParseExact(text, dateFormat,
                               CultureInfo.InvariantCulture,
                               DateTimeStyles.None);

                return date;
            }
            catch
            {
                throw new ArgumentException("The passed text is not in a valid DateTime format");
            }
        }

        private string DateFromText(string text, string keyWord)
        {
            // for now the length of the substring is just 10, because "01.01.2001" has length equal to 10
            int indexOfDate = text.IndexOf(keyWord);
            if (indexOfDate >= 0)
            {
                indexOfDate += keyWord.Length;
            }
            else
            {
                throw new ArgumentException("The text does not contain someting about person being \'" + keyWord + "\' some date.");
            }

            string foundDate = text.ToLower().Substring(indexOfDate, 10);
            return foundDate;
        }
    }
}
