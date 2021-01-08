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
    public partial class CourseworkDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                var courseworkID = Request.QueryString.Get("courseworkID");
                if (courseworkID == null)
                {
                    Response.Redirect("CourseworkPage.aspx");
                }
            
                CourseworkHandler ch = new CourseworkHandler();
                RubricHandler rh = new RubricHandler();
                Coursework coursework = ch.getCoursework(int.Parse(courseworkID));

                lblCourseworkName.Text = coursework.getCourseworkName();
                lblNoFileSubmission.Text = coursework.getNoFileSubmit().ToString();
                lblCourseworkDue.Text = coursework.getDueDate().ToString();

                if (coursework.getRubricID() != -1)
                {
                    Rubric rubric = rh.getRubric(coursework.getRubricID());
                    lblRubricAttached.Text = rubric.rubricName;
                }
                 initRubricList();
        }

        protected void initRubricList()
        {
            RubricHandler rh = new RubricHandler();
            RubricCollection rubrics = rh.getAllRubric();

            RubricIterator rubricIterator = (RubricIterator)rubrics.createIterator();

            while (rubricIterator.hasNext())
            {

                Rubric rubric = (Rubric)rubricIterator.getNext();
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                TableCell tc2 = new TableCell();
                TableCell tc3 = new TableCell();
                Button btnView = new Button();
                Button btnSelect = new Button();
                tc1.Text = rubric.rubricName;

                btnView.Text = "View";
                //   btnView.Click += openRubricDetailPage;
                btnView.OnClientClick = "window.open('RubricDetailPage.aspx?rubricID=" + rubric.rubricID.ToString() + "'); return false;";
                btnView.CommandName = rubric.rubricID.ToString();


                btnSelect.Text = "Attach";
                btnSelect.Click += attachRubric;
                btnSelect.CommandName = rubric.rubricID.ToString();

                tr.Cells.Add(tc1);

                tc2.Controls.Add(btnView);
                tr.Cells.Add(tc2);

                tc3.Controls.Add(btnSelect);
                tr.Cells.Add(tc3);


                tblRubrics.Rows.Add(tr);
            }
       
        }

        protected void openRubricDetailPage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var rubricID = btn.CommandName;
            //  Response.Write("window.open('RubricDetailPage.aspx?rubricID=" + rubricID + "')");
            // ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('RubricDetailPage.aspx');", true);
        }

        protected void attachRubric(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var rubricID = btn.CommandName;
            var courseworkID = Request.QueryString.Get("courseworkID");

            CourseworkHandler ch = new CourseworkHandler();
            ch.attachRubric(Int32.Parse(rubricID), Int32.Parse(courseworkID));
            Response.Redirect(Page.Request.RawUrl);
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}