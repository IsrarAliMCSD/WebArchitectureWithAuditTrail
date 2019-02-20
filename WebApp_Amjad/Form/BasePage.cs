using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebApp_Amjad.App_Class;

namespace WebApp_Amjad.Form
{
    public class BasePage : System.Web.UI.Page
    {
        protected virtual void Page_Load(object sender, EventArgs e)
        {

            if (Session[SessionNames.S_User.ToString()] == null)
            {
              //  Response.Redirect("~/login.aspx", true);
            }
            else
            {
                if (Session[SessionNames.S_User.ToString()] == null)
                {

                }
            }
        }
    }
}