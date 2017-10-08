using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Http;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(DashboardSignalR.Startup))]

namespace DashboardSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
        }
    }
}
