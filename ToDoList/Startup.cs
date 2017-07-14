using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JO.ToDoList.Startup))]
namespace JO.ToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
