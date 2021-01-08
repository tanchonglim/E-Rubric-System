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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RubricHandler rh = new RubricHandler();
            RubricCollection rubrics = rh.getAllRubric();

            RubricIterator rubricsIterator = (RubricIterator)rubrics.createIterator();

            while (rubricsIterator.hasNext())
            {
                Rubric rubric = (Rubric)rubricsIterator.getNext();
                TableRow tr = new TableRow();

                TableCell tc1 = new TableCell();
                tc1.Text = rubric.rubricName;
                tr.Cells.Add(tc1);

                TableCell tc3 = new TableCell();
                tc3.Text = rubric.RubricType;
                tr.Cells.Add(tc3);


                TableCell tc2 = new TableCell();
                Button btn = new Button();
                btn.Text = "View";
                btn.Click += gotoRubricDetailPage;
                btn.CommandName = rubric.rubricID.ToString();
                tc2.Controls.Add(btn);

                tr.Cells.Add(tc2);

                tblRubrics.Rows.Add(tr);

               
            }


        }

        protected void gotoRubricDetailPage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var rubricID = btn.CommandName;

           Response.Redirect("/UI/RubricDetailPage.aspx?rubricID="+ rubricID);
        }

        protected void gotoRubricCreatePage(object sender, EventArgs e)
        {
            Response.Redirect("/UI/RubricCreatePage.aspx");
        }
    }
}