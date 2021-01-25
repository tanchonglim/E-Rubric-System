using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL;

namespace E_Rubric_System.UI
{
    public partial class StudentCourseworkSubmissionPage : System.Web.UI.Page
    {
       
        Submission submission = null;
        Coursework coursework = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            alert.Visible = false;
            var studentID = Session["student"];
            var courseworkID = Request.QueryString.Get("courseworkID");

            if(courseworkID == null)
            {
                Response.Redirect("StudentCourseworkListPage.aspx");
            }
            if(studentID == null)
            {
                Response.Redirect("StudentCourseworkListPage.aspx");
            }

            CourseworkHandler ch = new CourseworkHandler();
            SubmissionHandler sh = new SubmissionHandler();

            coursework = ch.getCoursework(Int32.Parse(courseworkID));

            courseworkTitle.InnerText = coursework.getCourseworkName();
            dueDate.InnerText = coursework.getDueDate().ToString();
            timeRemain.InnerText = (coursework.getDueDate() - DateTime.Now).Days.ToString() + " days " +
                ((coursework.getDueDate() - DateTime.Now).Hours).ToString() + " hours";
            timeRemain.BgColor = (coursework.getDueDate() - DateTime.Now).TotalDays < 0 ? "#ff9898" : "white";
            submission = sh.getOneSubmission(Int32.Parse(courseworkID), Int32.Parse(studentID.ToString()));
            if(submission == null)
            {
                btnSubmit.Enabled = true;
            } else
            {
                status.InnerText = submission.SubmissionStatus;
                status.InnerText += submission.IsLate ? " (Late Submission)" : "";
                status.BgColor = submission.IsLate ? "#ff9898" : "#cfefcf";
                grade.InnerText = submission.Grade.ToString() == "" ? "-" : submission.Grade.ToString();
                marks.InnerText = submission.Marks.ToString() == "-1"? "-" : submission.Marks.ToString();
                timeRemain.InnerText = "-";
                timeRemain.BgColor = "white";
                txtSubmissionText.Text = submission.SubmissionText;
                btnSubmit.Enabled = false;
                txtSubmissionText.ReadOnly = true;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSubmissionText.Text.Equals(""))
            {
                alert.Visible = true;
                return;
            }
            var studentID = Session["student"];
            var courseworkID = Request.QueryString.Get("courseworkID");
            SubmissionHandler sh = new SubmissionHandler();
            var submissionText = txtSubmissionText.Text;
            var submissionStatus = "Submitted";
            var submissionIsLate = false;

            if (coursework.getDueDate().CompareTo(DateTime.Now) < 0)
            {
                submissionIsLate = true;
            }
           

            sh.submitCoursework(Int32.Parse(studentID.ToString()), submissionText, submissionStatus, Int32.Parse(courseworkID), submissionIsLate);
            

     

            Response.Redirect(Request.RawUrl);
        }
    }
}