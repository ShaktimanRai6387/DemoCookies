using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies.SessionObj
{
    public partial class FamilyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] == null)
            {
                Response.Redirect("~/SessionObj/PersonalDetails.aspx");
            }
            else
            {
                txtSpouseName.Focus();
            }
        }

        protected void btnNextPage_Click(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {
                Dictionary<string, string> Details =  (Dictionary<string, string>)Session["UserDetails"];
                Details.Add("SpouseName",txtSpouseName.Text);
                Details.Add("FatherName",txtFatherName.Text);
                Details.Add("MotherName",txtMotherName.Text);
                Details.Add("Children",txtChildren.Text);
                Session["UserDetails"] = Details;
                Response.Redirect("~/SessionObj/DisplayDetails.aspx");
            }
            else
            {
                Response.Redirect("~/SessionObj/PersonalDetails.aspx");
            }
        }
    }
}