using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies.SessionObj
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNextPage_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> Details = new Dictionary<string,string>();
            Details.Add("FirstName",txtFirstName.Text);
            Details.Add("LastName",txtLastName.Text);
            Details.Add("Email",txtEmail.Text);
            Details.Add("Mobile",txtMobile.Text);
            Session["UserDetails"]= Details;
            Response.Redirect("~/SessionObj/FamilyDetails.aspx");
        }
    }
}