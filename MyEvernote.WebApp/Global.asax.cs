using MyEvernote.Common;
using MyEvernote.WebApp.Init;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyEvernote.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // yaz�lan bu metodla App.Common metodu art�k WebCommon() class ile �l��acak. Burada bu metod yaz�lmasayd� e�er Common katman�ndaki DefaultCommon metoduyla �al��acakt�r.
            // Art�k Common katman�ndaki App class �na WebCommon()  metodonu set ettik.
            App.Common = new WebCommon(); 
        }
    }
}
