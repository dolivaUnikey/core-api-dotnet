using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnikeyDemo.Startup))]
namespace UnikeyDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
