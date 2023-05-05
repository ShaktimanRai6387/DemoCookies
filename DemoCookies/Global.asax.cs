using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace DemoCookies
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Total_User"] = 0;
            Application["Number_of_Online_User"] = 0;
        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
        protected void Application_Error(object sender, EventArgs e)
        {

        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Tatal_User"] = (int)Application["Total_User"] + 1;
            Application["Number_of_Online_User"] = (int)Application["Number_of_Online_User"] + 1;
            Application.UnLock();
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Number_of_Online_User"] = (int)Application["Number_of_Online_User"] - 1;
            Application.UnLock();
        }
      
    }
}