using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Rubric_System.BLL
{
    public class HolisticRubric : Rubric
    {
        public HolisticRubric() : base() {
            RubricType = "holistic";
            Excellent = "";
            Good = "";
            Satisfactory = "";
            Fair = "";
            Poor = "";
        }

        override
     public Table getRubricTable()
        {
            Table tbl = new Table();

            //add first row (title)
            TableRow tr1 = new TableRow();
            TableCell tc1 = null;
            string[] titles = { "Excellent (100-90)", "Good (89-80)", "Satisfactory (79-60)", "Fair (59-40)", "Poor (39-0)" };

            foreach (string title in titles) 
            {
                tc1 = new TableCell();
                tc1.Text = title;
                tr1.Cells.Add(tc1);
            }

            tbl.Rows.Add(tr1);

            //add description rows
            TableRow tr2 = new TableRow();
            TableCell[] cells = new TableCell[5];

            cells[0] = new TableCell();
            TextBox txtBox0 = new TextBox();
            txtBox0.TextMode = TextBoxMode.MultiLine;
            txtBox0.Attributes.Add("placeholder", "type something");
            txtBox0.Text = Excellent;
            txtBox0.Height = Unit.Pixel(500);
            txtBox0.CssClass = "form-control";
            cells[0].Controls.Add(txtBox0);
            tr2.Cells.Add(cells[0]);

            cells[1] = new TableCell();
            TextBox txtBox1 = new TextBox();
            txtBox1.TextMode = TextBoxMode.MultiLine;
            txtBox1.Attributes.Add("placeholder", "type something");
            txtBox1.Text = Good;
            txtBox1.Height = Unit.Pixel(500);
            txtBox1.CssClass = "form-control";
            cells[1].Controls.Add(txtBox1);
            tr2.Cells.Add(cells[1]);

            cells[2] = new TableCell();
            TextBox txtBox2 = new TextBox();
            txtBox2.TextMode = TextBoxMode.MultiLine;
            txtBox2.Attributes.Add("placeholder", "type something");
            txtBox2.Text = Satisfactory;
            txtBox2.Height = Unit.Pixel(500);
            txtBox2.CssClass = "form-control";
            cells[2].Controls.Add(txtBox2);
            tr2.Cells.Add(cells[2]);

            cells[3] = new TableCell();
            TextBox txtBox3 = new TextBox();
            txtBox3.TextMode = TextBoxMode.MultiLine;
            txtBox3.Attributes.Add("placeholder", "type something");
            txtBox3.Text = Fair;
            txtBox3.Height = Unit.Pixel(500);
            txtBox3.CssClass = "form-control";
            cells[3].Controls.Add(txtBox3);
            tr2.Cells.Add(cells[3]);

            cells[4] = new TableCell();
            TextBox txtBox4 = new TextBox();
            txtBox4.TextMode = TextBoxMode.MultiLine;
            txtBox4.Attributes.Add("placeholder", "type something");
            txtBox4.Text = Poor;
            txtBox4.Height = Unit.Pixel(500);
            txtBox4.CssClass = "form-control";
            cells[4].Controls.Add(txtBox4);
            tr2.Cells.Add(cells[4]);

            tr2.Cells.AddRange(cells);

            tbl.Rows.Add(tr2);

            return tbl;
        }

        override
        public void updateRubric(Table table)
        {
            this.Excellent = "";
            this.Good = "";
            this.Satisfactory = "";
            this.Fair = "";
            this.Poor = "";

            var row = table.Rows[1];

            var excellent = (row.Cells[0].Controls[0] as TextBox).Text;
            var good = (row.Cells[1].Controls[0] as TextBox).Text;
            var satisfiable = (row.Cells[2].Controls[0] as TextBox).Text;
            var fair = (row.Cells[3].Controls[0] as TextBox).Text;
            var poor = (row.Cells[4].Controls[0] as TextBox).Text;

            this.Excellent += excellent;
            this.Good += good;
            this.Satisfactory += satisfiable;
            this.Fair += fair;
            this.Poor += poor;
        }

        override
        public Table getMarkingRubric()
        {
            Table tbl = new Table();

            TableRow tr = new TableRow();
            TableCell tc01 = new TableCell();
            tc01.Text = "Marks: ";
            tr.Cells.Add(tc01);

            TableCell tc02 = new TableCell();
            tc02.ColumnSpan = 4;
            TextBox tb = new TextBox();
            tb.Attributes.Add("type","number");
            tb.Attributes.Add("min", "0");
            tb.Attributes.Add("max", "130");
            tb.Attributes.Add("placeholder", "Input marks");
            tb.Attributes.Add("required","true");
            tb.Width = Unit.Pixel(100);
            tc02.Controls.Add(tb);
            tr.Cells.Add(tc02);

            tbl.Rows.Add(tr);
            
            TableRow tr1 = new TableRow();
            TableCell tc1 = null;
            string[] titles = { "Excellent (100-75)", "Good (74-65)", "Satisfactory (64-60)", "Fair (59-45)", "Poor (44-0)" };

            foreach (string title in titles)
            {
                tc1 = new TableCell();
                tc1.Text = title;
                tc1.Attributes.Add("class", "text-center");
                tr1.Cells.Add(tc1);
                
            }

            tbl.Rows.Add(tr1);

            //add description rows
            TableRow tr2 = new TableRow();
            TableCell[] cells = new TableCell[5];

            cells[0] = new TableCell();
            TextBox txtBox0 = new TextBox();
            txtBox0.TextMode = TextBoxMode.MultiLine;
            txtBox0.Attributes.Add("placeholder", "type something");
            txtBox0.Text = Excellent;
            txtBox0.Height = Unit.Pixel(500);
            txtBox0.CssClass = "form-control";
            txtBox0.ReadOnly = true;
            cells[0].Controls.Add(txtBox0);
            tr2.Cells.Add(cells[0]);

            cells[1] = new TableCell();
            TextBox txtBox1 = new TextBox();
            txtBox1.TextMode = TextBoxMode.MultiLine;
            txtBox1.Attributes.Add("placeholder", "type something");
            txtBox1.Text = Good;
            txtBox1.Height = Unit.Pixel(500);
            txtBox1.CssClass = "form-control";
            txtBox1.ReadOnly = true;
            cells[1].Controls.Add(txtBox1);
            tr2.Cells.Add(cells[1]);

            cells[2] = new TableCell();
            TextBox txtBox2 = new TextBox();
            txtBox2.TextMode = TextBoxMode.MultiLine;
            txtBox2.Attributes.Add("placeholder", "type something");
            txtBox2.Text = Satisfactory;
            txtBox2.Height = Unit.Pixel(500);
            txtBox2.CssClass = "form-control";
            txtBox2.ReadOnly = true;
            cells[2].Controls.Add(txtBox2);
            tr2.Cells.Add(cells[2]);

            cells[3] = new TableCell();
            TextBox txtBox3 = new TextBox();
            txtBox3.TextMode = TextBoxMode.MultiLine;
            txtBox3.Attributes.Add("placeholder", "type something");
            txtBox3.Text = Fair;
            txtBox3.Height = Unit.Pixel(500);
            txtBox3.CssClass = "form-control";
            txtBox3.ReadOnly = true;
            cells[3].Controls.Add(txtBox3);
            tr2.Cells.Add(cells[3]);

            cells[4] = new TableCell();
            TextBox txtBox4 = new TextBox();
            txtBox4.TextMode = TextBoxMode.MultiLine;
            txtBox4.Attributes.Add("placeholder", "type something");
            txtBox4.Text = Poor;
            txtBox4.Height = Unit.Pixel(500);
            txtBox4.CssClass = "form-control";
            txtBox4.ReadOnly = true;
            cells[4].Controls.Add(txtBox4);
            tr2.Cells.Add(cells[4]);

            tr2.Cells.AddRange(cells);

            tbl.Rows.Add(tr2);

            return tbl;

        }

        override
        public int getMarks(Table table)
        {
            int marks = 0;
            marks = Int32.Parse((table.Rows[0].Cells[1].Controls[0] as TextBox).Text.ToString());
            return marks;
        }

    }
}