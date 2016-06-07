using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeatherForecast.Startup))]
namespace WeatherForecast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
