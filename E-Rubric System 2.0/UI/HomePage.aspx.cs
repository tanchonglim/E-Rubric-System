using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Rubric_System.UI
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Session["role"] = "cc";
            }

            if (Session["role"].ToString().Equals("cc"))
            {
                lectText.Visible = false;
                ccText.Visible = true;
                stdText.Visible = false;

            } else if(Session["role"].ToString().Equals("lecturer"))
            {
                lectText.Visible = true;
                ccText.Visible = false;
                stdText.Visible = false;

            } else
            {
                lectText.Visible = false;
                ccText.Visible = false;
                stdText.Visible = true;
            }
        }

    }
}