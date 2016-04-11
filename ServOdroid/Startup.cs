using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServOdroid.Startup))]
namespace ServOdroid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            ConfigureAuth(app);
            app.MapSignalR();
            //app.UseSession();
        }
    }
}
