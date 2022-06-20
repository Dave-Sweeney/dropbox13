using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox13
{
    internal class Student
    {
        // fields
        private string studentId;
        private string studentName;
        private int studentScore;

        public string StudentId 
        { 
            get { return studentId; }
            set { studentId = value; } 
        }

        public string StudentName
        { 
            get { return studentName; } 
            set { studentName = value; }
        }

        public int StudentScore
        { 
            get { return studentScore; } 
            set { studentScore = value; }
        }

        // constructor
        public Student(string studentId, string studentName, int studentScore)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentScore = studentScore;
        }

        // method
        public char GetLetterGrade()
        {
            char letterGrade;
            if (StudentScore >= 90)
            {
                letterGrade = 'A';
            }
            else if (StudentScore >= 80)
            {
                letterGrade = 'B';
            }
            else if (StudentScore >= 70)
            {
                letterGrade = 'C';
            }
            else if (StudentScore >= 60)
            {
                letterGrade = 'D';
            } 
            else 
            {
                letterGrade = 'F';
            }

            return letterGrade;
        }

        // ToString() method
        public override string ToString()
        {
            string str;
            str = string.Format("ID: {0} Name: {1} Grade: {2}", StudentId, StudentName, GetLetterGrade());
            return str;
        }

    }
}
