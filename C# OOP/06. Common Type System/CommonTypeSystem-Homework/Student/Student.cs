
namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public uint Course { get; set; }
        public UniversityEnum University { get; set; }
        public FacultyEnum Faculty { get; set; }
        public SpecialityEnum Speciality { get; set; }

        public enum UniversityEnum
        {
            SofiaUniversity,
            UNSS,
            NBU

        }

        public enum FacultyEnum
        {
            Mathematics,
            Economy,
            Medicine

        }

        public enum SpecialityEnum
        {
            Programming,
            BussinesRelations,
            Dentist
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string phone, string email)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }

        public void FillUniversityInfo(UniversityEnum university, uint course, FacultyEnum faculty, SpecialityEnum speciality)
        {
            this.University = university;
            this.Course = course;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public object Clone()
        {
            Student temp = new Student(this.FirstName, this.MiddleName,
                this.LastName, this.SSN, this.Address, this.Phone, this.Email);
            temp.FillUniversityInfo(this.University, this.Course, this.Faculty, this.Speciality);

            return temp;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.Phone.Equals((obj as Student).Phone)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Speciality.Equals((obj as Student).Speciality)) return false;

            return true;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1.Equals(s2));
        }
        public override int GetHashCode()
        {
            int hash = 10;
            hash = (hash * 7) + this.SSN.GetHashCode();
            hash = (hash * 7) + this.Course.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("SSN: {0}", this.SSN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Phone: {0}", this.Phone));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("{0}, faculty: {1}, speciality: {2}, course {3}",
                this.University, this.Faculty, this.Speciality, this.Course));

            return result.ToString();
        }

    }

    
}
