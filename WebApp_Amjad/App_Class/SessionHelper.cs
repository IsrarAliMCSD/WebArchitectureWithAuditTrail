using DAOCLASSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Amjad.App_Class
{
    public class SessionHelper
    {
        public static UserSession getUserSession()
        {
            return ((UserSession)HttpContext.Current.Session[SessionNames.S_User.ToString()]);
        }

    }
}