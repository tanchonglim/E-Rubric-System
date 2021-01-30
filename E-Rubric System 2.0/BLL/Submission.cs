using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class Submission : Item
    {
        public int SubmissionID { get; set; }
        public int StudentID { get; set; }
        public string SubmissionText { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string SubmissionStatus { get; set; }
        public int CourseworkID { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
        public bool IsLate { get; set; }

        public Submission()
        {

        }

        public Submission(int submissionID, int studentID, string submissionText, DateTime submissionDate, string submissionStatus, int courseworkID, int marks, string grade, bool isLate)
        {
            SubmissionID = submissionID;
            StudentID = studentID;
            SubmissionText = submissionText;
            SubmissionDate = submissionDate;
            SubmissionStatus = submissionStatus;
            CourseworkID = courseworkID;
            Marks = marks;
            Grade = grade;
            IsLate = isLate;
        }

        public void calcGrade(int marks, DateTime dueDate)
        {
            //if late, deduct 5 marks
            if ((this.SubmissionDate - dueDate).Days > 0)
            {
                marks -= 5;
            }

            if (marks < 0) marks = 0;

            string grade;

            if (marks >= 90)
            {
                grade = "A+";
            }
            else if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 75)
            {
                grade = "A-";
            }
            else if (marks >= 70)
            {
                grade = "B+";
            }
            else if (marks >= 65)
            {
                grade = "B";
            }
            else if (marks >= 60)
            {
                grade = "B-";
            }
            else if (marks >= 55)
            {
                grade = "C+";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else if (marks >= 45)
            {
                grade = "C-";
            }
            else if (marks >= 40)
            {
                grade = "D+";
            }
            else if (marks >= 35)
            {
                grade = "D";
            }
            else if (marks >= 30)
            {
                grade = "D-";
            }
            else
            {
                grade = "E";
            }

            this.Marks = marks;
            this.Grade = grade;
        }
    }
}