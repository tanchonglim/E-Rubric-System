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
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //fetch list of students 
            StudentHandler sh = new StudentHandler();
            ArrayList students = sh.getAllStudent();

            foreach (Student student in students)
            {
                ListItem item = new ListItem();
                item.Value = student.StudentID.ToString();
                item.Text = student.StudentName;
                dropDownStudent.Items.Add(item);
            }


            if (Session["role"] == null)
            {
                Session["role"] = "cc";
            }

            if(Session["student"] == null)
            {
                Session["student"] = "1";
            }

            if (!IsPostBack)
            {
                if (Session["role"] != null && Session["role"].ToString().Equals("cc"))
                {
                    dropDownRole.SelectedIndex = 0;
                } else if (Session["role"].ToString().Equals("lecturer"))
                {
                    dropDownRole.SelectedIndex = 1;
                } else 
                {
                    dropDownRole.SelectedIndex = 2;
                }

                if(Session["student"] != null)
                {
                    dropDownStudent.SelectedValue = Session["student"].ToString();
                }

            }

            if (Session["role"] != null && Session["role"].ToString().Equals("cc"))
            {
                navbarStd.Visible = false;
                navbarCC.Visible = true;
                navbarLect.Visible = false;
                dropDownStudent.Visible = false;
            }
            else if (Session["role"].ToString().Equals("lecturer"))
            {
                navbarStd.Visible = false;
                navbarCC.Visible = false;
                navbarLect.Visible = true;
                dropDownStudent.Visible = false;
            } else
            {
                navbarStd.Visible = true;
                navbarCC.Visible = false;
                navbarLect.Visible = false;
                dropDownStudent.Visible = true;
            }

        }

        protected void onRoleChange(object sender, EventArgs e)
        {
            if(dropDownRole.SelectedIndex == 0)
            {
                Session["role"] = "cc";
            } else if (dropDownRole.SelectedIndex == 1)
            {
                Session["role"] = "lecturer";
            } else 
            {
                Session["role"] = "student";
            } 
                Response.Redirect("/UI/HomePage.aspx");

        }

        protected void onStudentChange(object sender, EventArgs e)
        {
            Session["student"] = dropDownStudent.SelectedValue.ToString();
            Response.Redirect("/UI/HomePage.aspx");
        }
    }
}