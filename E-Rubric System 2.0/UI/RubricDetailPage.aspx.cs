using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL ;

namespace E_Rubric_System.UI
{
    public partial class RubricDetailPage : System.Web.UI.Page

    {
        Rubric rubric;
        protected void Page_Load(object sender, EventArgs e)
        {
                viewMode.Visible = true;
                editMode2.Visible = false;
                editMode.Visible = false;
                RubricHandler rh = new RubricHandler();
                var rubricID = Request.QueryString.Get("rubricID");
                if (rubricID == null)
                {
                    Response.Redirect("RubricPage.aspx");
                }

                this.rubric = rh.getRubric(Int32.Parse(rubricID));
                

                if (!IsPostBack)
                {
                    txtRubricTitle.Text = rubric.rubricName;
                    Session.Add("rubric", rubric);
                } else
                {
                    rubric = Session["rubric"] as Rubric;
                }

                Table rubricTable = rubric.getRubricTable();

                TableRowCollection trc = rubricTable.Rows;
                List<TableRow> row = new List<TableRow>();
                for(int i = 0; i < trc.Count; i++)
                {
                    row.Add(trc[i]);
                }


                if (rubric.RubricType.Equals("holistic"))
                {
                    btnAddRow.Visible = false;
                    btnRemoveRow.Visible = false;
                }

                tblRubric.Rows.AddRange(row.ToArray());

                if (Request.QueryString.Get("mode")!= null && Request.QueryString.Get("mode").Equals("edit"))
                {
                    this.enableEditMode();
               
                }
                else
                {
                    this.enableViewMode();
                }
           

        }

        protected void gotoRubricPage(object sender, EventArgs e)
        {
            Response.Redirect("RubricPage.aspx");
        }

        protected void enableEditMode()
        {
            viewMode.Visible = false;
            editMode.Visible = true;
            editMode2.Visible = true;

            txtRubricTitle.ReadOnly = false;

            foreach (TableRow row in tblRubric.Rows) { 
            
                foreach(TableCell cell in row.Cells)
                {
                    if (cell.HasControls())
                    {
                        (cell.Controls[0] as TextBox).ReadOnly = false;
                    }
                  
                }
            }

        }

        protected void enableViewMode()
        {
            viewMode.Visible = true;
            editMode.Visible = false;
            editMode2.Visible = false;

            txtRubricTitle.ReadOnly = true;

            foreach (TableRow row in tblRubric.Rows)
            {

                foreach (TableCell cell in row.Cells)
                {
                    if (cell.HasControls())
                    {
                        (cell.Controls[0] as TextBox).ReadOnly = true;
                    }

                }
            }

        }


        protected void updateRubric(object sender, EventArgs e)
        {
            //perform update
            var rubricID = Request.QueryString.Get("rubricID");
            this.rubric.updateRubric(tblRubric);

            var rubricName = txtRubricTitle.Text;
            var criteria = rubric.Criteria;
            var poor = rubric.Poor;
            var satisfactory = rubric.Satisfactory;
            var fair = rubric.Fair;
            var good = rubric.Good;
            var excellent = rubric.Excellent;

            RubricHandler rh = new RubricHandler();

            rh.updateRubric(rubricName, criteria, poor, fair, satisfactory, good, excellent, Int32.Parse(rubricID));

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Update success", "alert('Update success'); window.location = 'RubricDetailPage.aspx?rubricID=" + rubricID + "';", true);
            //Page.Response.Redirect("RubricDetailPage.aspx?rubricID=" + rubricID);
        }

        protected void deleteRubric(object sender, EventArgs e)
        {
            //perform delete
            var rubricID = Request.QueryString.Get("rubricID");
            RubricHandler rh = new RubricHandler();
            rh.deleteRubric(Int32.Parse(rubricID));

            ScriptManager.RegisterStartupScript(this, this.GetType(),
            "alert",
            "alert('Rubric delete sucessfully');window.location ='RubricPage.aspx';",
            true);

            // Page.Response.Redirect("RubricPage.aspx", true);
        }

        protected void enableViewMode(object sender, EventArgs e)
        {
            var rubricID = Request.QueryString.Get("rubricID");
            Page.Response.Redirect("RubricDetailPage.aspx?rubricID="+ rubricID);
        }

        protected void goEditMode(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.RawUrl+"&mode=edit", true);
        }

        protected void btnAddRow_Click(object sender, EventArgs e)
        {
            this.rubric.Criteria += "|";
            this.rubric.Excellent += "|";
            this.rubric.Good += "|";
            this.rubric.Satisfactory += "|";
            this.rubric.Fair += "|";
            this.rubric.Poor += "|";

            Table rubricTable = rubric.getRubricTable();

            TableRowCollection trc = rubricTable.Rows;
            List<TableRow> row = new List<TableRow>();

            for (int i = 0; i < trc.Count; i++)
            {
                row.Add(trc[i]);
            }

            tblRubric.Rows.Add(row.ToArray()[trc.Count - 1]);
        }

        protected void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (this.rubric.Criteria.Split('|').Length > 2)
            {
                this.rubric.Criteria = this.rubric.Criteria.Substring(0, this.rubric.Criteria.LastIndexOf('|'));
                this.rubric.Excellent = this.rubric.Excellent.Substring(0, this.rubric.Excellent.LastIndexOf('|'));
                this.rubric.Good = this.rubric.Good.Substring(0, this.rubric.Good.LastIndexOf('|'));
                this.rubric.Satisfactory = this.rubric.Satisfactory.Substring(0, this.rubric.Satisfactory.LastIndexOf('|'));
                this.rubric.Fair = this.rubric.Fair.Substring(0, this.rubric.Fair.LastIndexOf('|'));
                this.rubric.Poor = this.rubric.Poor.Substring(0, this.rubric.Poor.LastIndexOf('|'));

                Table rubricTable = rubric.getRubricTable();

                TableRowCollection trc = rubricTable.Rows;
                List<TableRow> row = new List<TableRow>();

                for (int i = 0; i < trc.Count; i++)
                {
                    row.Add(trc[i]);
                }

                tblRubric.Rows.RemoveAt(tblRubric.Rows.Count - 1);
            }
        }
    }
}