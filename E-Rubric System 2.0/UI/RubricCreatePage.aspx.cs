using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using E_Rubric_System.BLL;

namespace E_Rubric_System.UI
{
    public partial class RubricCreatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createNewRubric(object sender, EventArgs e)
        {
            string rubricName = txtRubricTitle.Text;
            string criteria = txtCriteria1.Text + "|" + txtCriteria2.Text + "|" + txtCriteria3.Text;
            string poor = txtPoor1.Text + "|" + txtPoor2.Text + "|" + txtPoor3.Text;
            string fair = txtFair1.Text + "|" + txtFair2.Text + "|" + txtFair3.Text;
            string satisfactory = txtStatis1.Text + "|" + txtStatis2.Text + "|" + txtStatis3.Text;
            string good = txtGood1.Text + "|" + txtGood2.Text + "|" + txtGood3.Text;
            string excellent = txtExcel1.Text + "|" + txtExcel2.Text + "|" + txtExcel3.Text;

            RubricHandler rh = new RubricHandler();
            rh.createRubric(rubricName, criteria, poor, fair, satisfactory, good, excellent);
            Response.Redirect("RubricPage.aspx");
        }
    }
}