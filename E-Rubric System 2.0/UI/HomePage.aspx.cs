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

        }

        protected void gotoRubricPage(object sender, EventArgs e)
        {
            Response.Redirect("/UI/RubricPage.aspx");
        }

        protected void gotoCourseworkPage(object sender, EventArgs e)
        {
            Response.Redirect("/UI/CourseworkPage.aspx");
        }
    }
}