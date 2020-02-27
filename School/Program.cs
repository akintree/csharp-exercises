using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        public string name { get; set; }
        protected internal int studentId { get; set; }
        public int numberOfCredits { get; set; }
        public double gpa { get; set; }

        //Student(string Name, int StudentId, int NumberOfCredits, double GPA)
        //{
        //    Name = name;
        //    StudentId = studentId;
        //    NumberOfCredits = numberOfCredits;
        //    GPA = gpa;
        //}

        public void AddGrade(int courseCredits, double grade)
        {
            double totalScore = gpa * numberOfCredits;
            totalScore += (grade* courseCredits);
            gpa = totalScore/numberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (numberOfCredits <= 29)
            {
                return "Freshman";
            } else if (numberOfCredits >= 30 && numberOfCredits <= 59)
            {
                return "Sophomore";
            } else if (numberOfCredits >= 60 && numberOfCredits <= 89)
            {
                return "Junior";
            } else
            {
                return "Senior";
            }
        }

        public override string ToString()
        {
            return "Student:" + name + " GPA: " + gpa;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            Student studentObject = obj as Student;
            return studentId == studentObject.studentId;
        }

        public override int GetHashCode()
        {
            return studentId;
        }
    }

    public class Course
    {
        string courseName;
        Dictionary<string, string> courseDetails = new Dictionary<string, string>();
        private Student courseStudents = new Student();
        
    }

}
