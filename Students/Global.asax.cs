namespace Students
{
    using Students.Models;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            UnityConfig.RegisterComponents();

            SchoolContext con = new SchoolContext();
            con.Database.Initialize(true);
            con.Database.CreateIfNotExists();
        }
    }
}
