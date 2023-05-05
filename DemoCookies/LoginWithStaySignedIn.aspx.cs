using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies
{
    public partial class LoginWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCookie"];
            if(cookie != null)
            {
                Response.Redirect("SuccessWithStaySignedIn.aspx");
            }
            if(!IsPostBack)
            {
                ViewState["FailureCount"] = 0;
                txtUserName.Focus();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtPass.Text=="admin")
            {
                HttpCookie cookie = new HttpCookie("LoginCookie");
                cookie["UserName"]=txtUserName.Text;
                cookie["Password"]=txtPass.Text;
                if(cbStay.Checked)
                {
                    cookie.Expires= DateTime.Now.AddMonths(1);
                }
                Response.Cookies.Add(cookie);
                Response.Redirect("SuccessWithStaySignedIn.aspx");
            }
            else
            {
                int Count = (int)ViewState["FailureCount"] + 1;
                if(Count == 3) 
                {
                    Response.Cookies["UserName"].Value = txtUserName.Text;
                    Response.Cookies["Count"].Value=Count.ToString();
                    Response.Redirect("FailureWithStaySignedIn.aspx");
                }
                ViewState["FailureCount"] = Count;
                lblMsg.Text = Count + "attempt(s) failed, maximum are 3.";
            }
        }
    }
}