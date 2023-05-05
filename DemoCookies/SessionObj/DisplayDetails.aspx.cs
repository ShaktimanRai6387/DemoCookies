using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies.SessionObj
{
    public partial class DisplayDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {
                Dictionary<string, string> Details = (Dictionary<string, string>)Session["UserDetails"];
                foreach(string key in Details.Keys)
                {
                    Response.Write(key + ":" + Details[key]+"<br/>");
                }
            }
            else 
            {
                Response.Redirect("~/SessionObj/PersonalDetails.aspx");
            }

        }
    }
}