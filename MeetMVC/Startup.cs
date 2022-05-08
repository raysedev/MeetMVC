using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeetMVC.Startup))]
namespace MeetMVC
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }

    }
}
