using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies
{
    public partial class SuccessWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCookie"];
            if (cookie != null)
            {
                Response.Redirect("LoginWithStaySignedIn.aspx");
            }
            string Name = cookie["UserName"];
            Response.Write("<h3>Hello" + Name + ", Welcome to the site.</h3>");
        }
    }
}