using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL;

namespace E_Rubric_System.UI
{
    public partial class CourseworkSubmissionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var courseworkID = Request.QueryString.Get("courseworkID");
            if (courseworkID == null)
            {
                Response.Redirect("CourseworkPage.aspx");
            }

            courseworkDetail.HRef += "?courseworkID=" + courseworkID;

            //fetching submission lists 

            SubmissionHandler sh = new SubmissionHandler();
            StudentHandler stdh = new StudentHandler();

            SubmissionCollection submissions = sh.getSubmissionByCourseworkID(Int32.Parse(courseworkID));

            SubmissionIterator submissionIterator = (SubmissionIterator)submissions.createIterator();

            int counter = 1;
            while (submissionIterator.hasNext())
            {
                Submission submission = (Submission)submissionIterator.getNext();

                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                tc1.Text = counter.ToString();
                tr.Cells.Add(tc1);

                Student student = stdh.getStudentByID(submission.StudentID);
                TableCell tc2 = new TableCell();
                tc2.Text = student.StudentName;
                tr.Cells.Add(tc2);

                TableCell tc3 = new TableCell();
                tc3.Text = submission.SubmissionStatus.ToString();
                tr.Cells.Add(tc3);

                TableCell tc4 = new TableCell();
                tc4.Text = submission.Marks.ToString() == "-1" ? "-" : submission.Marks.ToString();
                tr.Cells.Add(tc4);

                TableCell tc5 = new TableCell();
                tc5.Text = submission.Grade.ToString() == "" ? "-" : submission.Grade.ToString();
                tr.Cells.Add(tc5);

                TableCell tc6 = new TableCell();
                Button btn = new Button();
                btn.Text = "View";
                btn.Click += gotoSubmissionGradingPage;
                btn.CommandName = submission.SubmissionID.ToString();
                btn.CssClass = "btn btn-outline-success";
                tc6.Controls.Add(btn);
                tr.Cells.Add(tc6);

                tblSubmissions.Rows.Add(tr);
                counter++;
            }

        }

        protected void gotoSubmissionGradingPage(object sender, EventArgs e)
        {
            var courseworkID = Request.QueryString.Get("courseworkID");
            Button btn = (Button)sender;
            var submissionID = btn.CommandName;

            Response.Redirect("/UI/CourseworkGradingPage.aspx?courseworkID="+ courseworkID + "&submissionID=" + submissionID);
        }
    }
}