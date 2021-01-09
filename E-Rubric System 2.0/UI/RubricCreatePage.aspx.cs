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
        Rubric rubric;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string rubricType = Request.QueryString.Get("rubricType");

            if (!IsPostBack) { 
            IRubricCreator rubricCreator = null;

            if (rubricType != null && rubricType.Equals("holistic"))
            {
                    dropDownRubricType.SelectedIndex = 1;
                    btnAddRow.Visible = false;
                    rubricCreator = new HolisticRubricCreator();
            }
                else
            {
                rubricCreator = new AnalyticRubricCreator();
               
            }

              rubric = rubricCreator.getRubric();
                Session.Add("rubric", rubric);
            } else
            {
                rubric = Session["rubric"] as Rubric;
            }

            Table rubricTable = rubric.getRubricTable();

            TableRowCollection trc = rubricTable.Rows;
            List<TableRow> row = new List<TableRow>();
            for (int i = 0; i < trc.Count; i++)
            {
                row.Add(trc[i]);
            }

            tblRubric.Rows.AddRange(row.ToArray());
        }

        protected void createNewRubric(object sender, EventArgs e)
        {
            rubric.updateRubric(tblRubric);
            var rubricName = txtRubricTitle.Text;
            var criteria = rubric.Criteria;
            var poor = rubric.Poor;
            var fair = rubric.Fair;
            var satisfactory = rubric.Satisfactory;
            var good = rubric.Good;
            var excellent = rubric.Excellent;
            var rubricType = rubric.RubricType;
            RubricHandler rh = new RubricHandler();
            rh.createRubric(rubricName, criteria, poor, fair, satisfactory, good, excellent, rubricType);
            Response.Redirect("RubricPage.aspx");
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

            tblRubric.Rows.Add(row.ToArray()[trc.Count-1]);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in dropDownRubricType.Items)
            {
                if (item.Selected)
                {
                    Page.Response.Redirect("RubricCreatePage.aspx?rubricType=" + item.Value);

                }
               
            }
           
            
        }
    }
}