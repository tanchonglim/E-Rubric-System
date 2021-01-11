using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Rubric_System.BLL
{
    public class AnalyticRubric: Rubric
    {
        public AnalyticRubric(): base() {
            RubricType = "analytic";
            Criteria = "|";
            Excellent = "|";
            Good = "|";
            Satisfactory = "|";
            Fair = "|";
            Poor = "|";
        }

        override
        public Table getRubricTable()
        {
            Table tbl = new Table();

            //add first row (title)
            TableRow tr1 = new TableRow();
            TableCell tc1 = null;
            string[] titles = { "Criteria", "Excellent", "Good", "Satisfactory", "Fair", "Poor" };

            foreach (string title in titles)
            {
                tc1 = new TableCell();
                tc1.Text = title;
                tr1.Cells.Add(tc1);
            }
            tbl.Rows.Add(tr1);

            //add other rows
            for (int i = 0; i < this.Criteria.Split('|').Length; i++)
            {
                TableCell criteriaCell = new TableCell();
                TableRow tr = new TableRow();
                //criteria
                TextBox txtBoxCriteria = new TextBox();
                txtBoxCriteria.TextMode = TextBoxMode.MultiLine;
                txtBoxCriteria.Attributes.Add("placeholder", "type something");
                txtBoxCriteria.Text = this.Criteria.Split('|')[i];
                txtBoxCriteria.Height = Unit.Pixel(250);
                txtBoxCriteria.CssClass = "form-control";
                criteriaCell.Controls.Add(txtBoxCriteria);
                tr.Cells.Add(criteriaCell);

                TableCell[] cells = new TableCell[5];

                //all attributes
                cells[0] = new TableCell();
                TextBox txtBox1 = new TextBox();
                txtBox1.TextMode = TextBoxMode.MultiLine;
                txtBox1.Attributes.Add("placeholder", "type something");
                txtBox1.Text = Excellent.Split('|')[i];
                txtBox1.Height = Unit.Pixel(250);
                txtBox1.CssClass = "form-control";
                cells[0].Controls.Add(txtBox1);
                tr.Cells.Add(cells[0]);

                cells[1] = new TableCell();
                TextBox txtBox2 = new TextBox();
                txtBox2.TextMode = TextBoxMode.MultiLine;
                txtBox2.Attributes.Add("placeholder", "type something");
                txtBox2.Text = Good.Split('|')[i];
                txtBox2.Height = Unit.Pixel(250);
                txtBox2.CssClass = "form-control";
                cells[1].Controls.Add(txtBox2);
                tr.Cells.Add(cells[1]);

                cells[2] = new TableCell();
                TextBox txtBox3 = new TextBox();
                txtBox3.TextMode = TextBoxMode.MultiLine;
                txtBox3.Attributes.Add("placeholder", "type something");
                txtBox3.Text = Satisfactory.Split('|')[i];
                txtBox3.Height = Unit.Pixel(250);
                txtBox3.CssClass = "form-control";
                cells[2].Controls.Add(txtBox3);
                tr.Cells.Add(cells[2]);

                cells[3] = new TableCell();
                TextBox txtBox4 = new TextBox();
                txtBox4.TextMode = TextBoxMode.MultiLine;
                txtBox4.Attributes.Add("placeholder", "type something");
                txtBox4.Text = Fair.Split('|')[i];
                txtBox4.Height = Unit.Pixel(250);
                txtBox4.CssClass = "form-control";
                cells[3].Controls.Add(txtBox4);
                tr.Cells.Add(cells[3]);

                cells[4] = new TableCell();
                TextBox txtBox5 = new TextBox();
                txtBox5.TextMode = TextBoxMode.MultiLine;
                txtBox5.Attributes.Add("placeholder", "type something");
                txtBox5.Text = Poor.Split('|')[i];
                txtBox5.Height = Unit.Pixel(250);
                txtBox5.CssClass = "form-control";
                cells[4].Controls.Add(txtBox5);
                tr.Cells.Add(cells[4]);

                tr.Cells.AddRange(cells);

                tbl.Rows.Add(tr);
            }
            return tbl;
        }

        override
        public void updateRubric(Table table)
        {
            this.Criteria = "";
            this.Excellent = "";
            this.Good = "";
            this.Satisfactory = "";
            this.Fair = "";
            this.Poor = "";


            //start from 1, ignore first row (title)
            for (int i=1;i<table.Rows.Count; i++)
            {
                var row = table.Rows[i];

                var criteria = (row.Cells[0].Controls[0] as TextBox).Text;
                var excellent = (row.Cells[1].Controls[0] as TextBox).Text;
                var good = (row.Cells[2].Controls[0] as TextBox).Text;
                var satisfiable = (row.Cells[3].Controls[0] as TextBox).Text;
                var fair = (row.Cells[4].Controls[0] as TextBox).Text;
                var poor = (row.Cells[5].Controls[0] as TextBox).Text;

                this.Criteria += criteria ;
                this.Excellent += excellent;
                this.Good += good;
                this.Satisfactory += satisfiable;
                this.Fair += fair;
                this.Poor += poor;

                if (i != (table.Rows.Count - 1))
                {
                    this.Criteria += "|";
                    this.Excellent += "|";
                    this.Good += "|";
                    this.Satisfactory += "|";
                    this.Fair += "|";
                    this.Poor += "|";
                }

            }
       

        }
    }
}