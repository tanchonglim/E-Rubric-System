using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL;

namespace E_Rubric_System.UI
{
    public partial class CourseworkPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CourseworkHandler ch = new CourseworkHandler();

           CourseworkCollection courseworks = ch.getAllCoursework();

            CourseworkIterator courseworkIterator = (CourseworkIterator)courseworks.createIterator();

            while (courseworkIterator.hasNext()) {
                Coursework coursework = (Coursework)courseworkIterator.getNext();
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                tc1.Text = coursework.getCourseworkName();
                tr.Cells.Add(tc1);
                TableCell tc2 = new TableCell();
                Button btn = new Button();
                btn.Text = "View";
                btn.Click += gotoCourseworkDetailPage;
                btn.CommandName = coursework.getCourseworkID().ToString();
                btn.CssClass= "btn btn-outline-success";
                tc2.Controls.Add(btn);

                tr.Cells.Add(tc2);

                tblCourseworks.Rows.Add(tr);
            }
        }

        protected void btnNewCoursework_Click(object sender, EventArgs e)
        {

        }

        protected void gotoCourseworkDetailPage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var courseworkID = btn.CommandName;

            Response.Redirect("/UI/CourseworkDetailPage.aspx?courseworkID=" + courseworkID);
        }
    }
}