using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies
{
    public partial class FailureWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserName"]==null || Request.Cookies["Count"] == null)
            {
                Response.Redirect("LoginWithStaySignedIn.aspx");
            }
            string Name= Request.Cookies["UserName"].Value;
            string Count= Request.Cookies["Count"].Value;
            Response.Write("<h3>Hello" + Name + ",You have failed all the" + Count + "attempts to login.</h3>");
        }
    }
}