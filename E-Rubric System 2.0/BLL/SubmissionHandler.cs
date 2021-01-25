using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using E_Rubric_System.DLL.ERSDataSetTableAdapters;
using System.Data;


namespace E_Rubric_System.BLL
{
    public class SubmissionHandler
    {
        private SubmissionTableAdapter sta;
        private CourseworkTableAdapter cta;
        public SubmissionHandler()
        {
            sta = new SubmissionTableAdapter();
            cta = new CourseworkTableAdapter();
        }
        ~SubmissionHandler()
        {

        }

        public SubmissionCollection getSubmissionByCourseworkID(int courseworkID)
        {
            SubmissionCollection submissions = new SubmissionCollection();

            var result = sta.selectSubmissionByCourseworkID(courseworkID);
            Submission submission = null;

            int counter = 0;
            foreach (DataRow row in result)
            {
                var submissionID = row["SubmissionID"].ToString();
                var studentID = row["StudentID"].ToString();
                var submissionText = row["SubmissionText"].ToString();
                var submissionDate = row["SubmissionDate"].ToString();
                var submissionStatus = row["SubmissionStatus"].ToString();
                var marks = row["Marks"].ToString() != "" ? row["Marks"].ToString() : "-1";
                var grade = row["Grade"].ToString();
                var isLate = row["IsLate"].ToString();
                var cID = row["CourseworkID"].ToString();

                submission = new Submission(Int32.Parse(submissionID), Int32.Parse(studentID), submissionText, DateTime.Parse(submissionDate), submissionStatus, courseworkID, Int32.Parse(marks), grade, bool.Parse(isLate));

                submissions[counter] = submission;
                counter++;
            }

            return submissions;
        } 

        public Submission getOneSubmission(int courseworkID, int studentID)
        {
            Submission submission = null;

            var result = sta.selectOneSubmission(courseworkID, studentID);

            foreach (DataRow row in result)
            {
                var submissionID = row["SubmissionID"].ToString();
                var submissionText = row["SubmissionText"].ToString();
                var submissionDate = row["SubmissionDate"].ToString();
                var submissionStatus = row["SubmissionStatus"].ToString();
                var marks = row["Marks"].ToString() != "" ? row["Marks"].ToString() : "-1";
                var grade = row["Grade"].ToString();
                var isLate = row["IsLate"].ToString();
                var cID = row["CourseworkID"].ToString();

                submission = new Submission(Int32.Parse(submissionID), studentID, submissionText, DateTime.Parse(submissionDate), submissionStatus, courseworkID, Int32.Parse(marks), grade, bool.Parse(isLate));
            }

            return submission;

        }

        public Submission getSubmissionByID(int submissionID)
        {
            Submission submission = null;

            var result = sta.selectSubmissionByID(submissionID);

            foreach (DataRow row in result)
            {
                var submissionText = row["SubmissionText"].ToString();
                var studentID = row["StudentID"].ToString();
                var courseworkID = row["CourseworkID"].ToString();
                var submissionDate = row["SubmissionDate"].ToString();
                var submissionStatus = row["SubmissionStatus"].ToString();
                var marks = row["Marks"].ToString() != "" ? row["Marks"].ToString() : "-1";
                var grade = row["Grade"].ToString();
                var isLate = row["IsLate"].ToString();
                var cID = row["CourseworkID"].ToString();

                submission = new Submission(submissionID, Int32.Parse(studentID), submissionText, DateTime.Parse(submissionDate), submissionStatus, Int32.Parse(courseworkID), Int32.Parse(marks), grade, bool.Parse(isLate));
            }

            return submission;
        }

        public void submitCoursework(int studentID, string SubmissionText, string SubmissionStatus, int courseworkID, bool IsLate)
        {
            cta.updateNoFileSubmit(courseworkID);
            sta.InsertSubmission(studentID, SubmissionText, SubmissionStatus, courseworkID, IsLate);
        }

        public void gradeSubmission(int marks, string grade, int submissionID)
        {
            string status = "Graded";
            sta.updateSubmission(status, marks, grade, submissionID);
        }

    }
}