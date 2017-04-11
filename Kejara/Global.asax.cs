using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Kejara.Models;

namespace Kejara
{
    // Remarque : pour obtenir des instructions sur l'activation du mode classique IIS6 ou IIS7, 
    // visitez http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code qui s'exécute à l'arrêt de l'application

        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception ex  = Server.GetLastError();
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code qui s'exécute lorsqu'une nouvelle session démarre

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code qui s'exécute lorsqu'une session se termine. 
            // Remarque : l'événement Session_End est déclenché uniquement lorsque le mode sessionstate a la valeur InProc dans le fichier Web.config. 
            // Si le mode de session a la valeur StateServer ou SQLServer, l'événement n'est pas déclenché.
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            //if (!Request.IsAuthenticated)
            //Response.Redirect("");
        }
    }
}