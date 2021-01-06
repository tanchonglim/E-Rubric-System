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
        protected void Page_Load(object sender, EventArgs e)
        {
            enableViewMode();
            if (!IsPostBack)
            {
                viewMode.Visible = true;
                editMode.Visible = false;
                RubricHandler rh = new RubricHandler();
                var rubricID = Request.QueryString.Get("rubricID");
                if (rubricID == null)
                {
                    Response.Redirect("RubricPage.aspx");
                }

                Rubric rubric = rh.getRubric(Int32.Parse(rubricID));

                txtRubricTitle.Text = rubric.getRubricName();

                txtCriteria1.Text = rubric.getCriteria().Split('|')[0];
                txtCriteria2.Text = rubric.getCriteria().Split('|')[1];
                txtCriteria3.Text = rubric.getCriteria().Split('|')[2];

                txtPoor1.Text = rubric.getPoor().Split('|')[0];
                txtPoor2.Text = rubric.getPoor().Split('|')[1];
                txtPoor3.Text = rubric.getPoor().Split('|')[2];

                txtFair1.Text = rubric.getFair().Split('|')[0];
                txtFair2.Text = rubric.getFair().Split('|')[1];
                txtFair3.Text = rubric.getFair().Split('|')[2];

                txtStatis1.Text = rubric.getSatisfactory().Split('|')[0];
                txtStatis2.Text = rubric.getSatisfactory().Split('|')[1];
                txtStatis3.Text = rubric.getSatisfactory().Split('|')[2];

                txtGood1.Text = rubric.getGood().Split('|')[0];
                txtGood2.Text = rubric.getGood().Split('|')[1];
                txtGood3.Text = rubric.getGood().Split('|')[2];

                txtExcel1.Text = rubric.getExcellent().Split('|')[0];
                txtExcel2.Text = rubric.getExcellent().Split('|')[1];
                txtExcel3.Text = rubric.getExcellent().Split('|')[2];
            }

        }



        protected void gotoRubricPage(object sender, EventArgs e)
        {
            Response.Redirect("RubricPage.aspx");
        }

        protected void enableEditMode(object sender, EventArgs e)
        {
            viewMode.Visible = false;
            editMode.Visible = true;

            txtRubricTitle.ReadOnly = false;
            txtCriteria1.ReadOnly = false;
            txtCriteria2.ReadOnly = false;
            txtCriteria3.ReadOnly = false;

            txtPoor1.ReadOnly = false;
            txtPoor2.ReadOnly = false;
            txtPoor3.ReadOnly = false;

            txtFair1.ReadOnly = false;
            txtFair2.ReadOnly = false;
            txtFair3.ReadOnly = false;

            txtStatis1.ReadOnly = false;
            txtStatis2.ReadOnly = false;
            txtStatis3.ReadOnly = false;

            txtGood1.ReadOnly = false;
            txtGood2.ReadOnly = false;
            txtGood3.ReadOnly = false;

            txtExcel1.ReadOnly = false;
            txtExcel2.ReadOnly = false;
            txtExcel3.ReadOnly = false;
        }

        protected void enableViewMode()
        {
            viewMode.Visible = true;
            editMode.Visible = false;

            txtRubricTitle.ReadOnly = true;
            txtCriteria1.ReadOnly = true;
            txtCriteria2.ReadOnly = true;
            txtCriteria3.ReadOnly = true;

            txtPoor1.ReadOnly = true;
            txtPoor2.ReadOnly = true;
            txtPoor3.ReadOnly = true;

            txtFair1.ReadOnly = true;
            txtFair2.ReadOnly = true;
            txtFair3.ReadOnly = true;

            txtStatis1.ReadOnly = true;
            txtStatis2.ReadOnly = true;
            txtStatis3.ReadOnly = true;

            txtGood1.ReadOnly = true;
            txtGood2.ReadOnly = true;
            txtGood3.ReadOnly = true;

            txtExcel1.ReadOnly = true;
            txtExcel2.ReadOnly = true;
            txtExcel3.ReadOnly = true;
        }


        protected void updateRubric(object sender, EventArgs e)
        {
            //perform update
            var rubricID = Request.QueryString.Get("rubricID");
            string rubricName = txtRubricTitle.Text.ToString();
            string criteria = txtCriteria1.Text + "|" + txtCriteria2.Text + "|" + txtCriteria3.Text;
            string poor = txtPoor1.Text + "|" + txtPoor2.Text + "|" + txtPoor3.Text;
            string fair = txtFair1.Text + "|" + txtFair2.Text + "|" + txtFair3.Text;
            string satisfactory = txtStatis1.Text + "|" + txtStatis2.Text + "|" + txtStatis3.Text;
            string good = txtGood1.Text + "|" + txtGood2.Text + "|" + txtGood3.Text;
            string excellent = txtExcel1.Text + "|" + txtExcel2.Text + "|" + txtExcel3.Text;

            RubricHandler rh = new RubricHandler();

            rh.updateRubric(rubricName, criteria, poor, fair, satisfactory, good, excellent, Int32.Parse(rubricID));

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Update success", "alert('Update success')", true);
            enableViewMode();
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
            enableViewMode();
        }
    }
}