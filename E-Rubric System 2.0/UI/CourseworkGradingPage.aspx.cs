using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL;

namespace E_Rubric_System.UI
{
    public partial class CourseworkGradingPage : System.Web.UI.Page
    {
        Rubric rubric;
        Submission submission;
        Coursework coursework;
        protected void Page_Load(object sender, EventArgs e)
        {
            var courseworkID = Request.QueryString.Get("courseworkID");
            var submissionID = Request.QueryString.Get("submissionID");
            if (courseworkID == null || submissionID == null)
            {
                Response.Redirect("CourseworkPage.aspx");
            }

            courseworkDetail.HRef += "?courseworkID=" + courseworkID;
            courseworkSubmission.HRef += "?courseworkID=" + courseworkID;

            SubmissionHandler sh = new SubmissionHandler();
            RubricHandler rh = new RubricHandler();
            CourseworkHandler ch = new CourseworkHandler();

            //get submission details
            submission = sh.getSubmissionByID(Int32.Parse(submissionID.ToString()));
            txtSubmissionText.Text = submission.SubmissionText;
            submissionDate.InnerText = submission.SubmissionDate.ToString();
            submissionStatus.InnerText = submission.SubmissionStatus;
            submissionStatus.InnerText += submission.IsLate ? " (Late Submission)" : "";
            marks.InnerText = submission.Marks.ToString() == "-1" ? "-": submission.Marks.ToString();
            grade.InnerText = submission.Grade == "" ? "-": submission.Grade;

            //get coursework details
            coursework = ch.getCoursework(submission.CourseworkID);
            courseworkDue.InnerText = coursework.getDueDate().ToString();

            //get rubric details
            if (coursework.getRubricID() == -1) //no rubric
            {
                Response.Redirect("/UI/CourseworkDetailPage.aspx?courseworkID=" + courseworkID);
            } else
            {
                rubric = rh.getRubric(coursework.getRubricID());
                //get rubric grading table
                TableRowCollection trc = rubric.getMarkingRubric().Rows;
                List<TableRow> row = new List<TableRow>();
                for (int i = 0; i < trc.Count; i++)
                {
                    row.Add(trc[i]);
                }
                tblGrading.Rows.AddRange(row.ToArray());

            }

        }

        protected void btnGrade_Click(object sender, EventArgs e)
        {
            var submissionID = Request.QueryString.Get("submissionID");
            var marks = rubric.getMarks(tblGrading);

            submission.calcGrade(marks, coursework.getDueDate());

            int finalMarks = submission.Marks;
            string grade = submission.Grade;

            SubmissionHandler sh = new SubmissionHandler();
            sh.gradeSubmission(finalMarks, grade, Int32.Parse(submissionID));
            Response.Redirect(Request.RawUrl);
        }
    }
}