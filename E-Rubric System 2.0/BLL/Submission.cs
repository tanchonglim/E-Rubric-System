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
    }
}