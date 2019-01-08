namespace Students
{
    using Students.BLL;
    using Students.IBLL;
    using System.Web.Mvc;
    using Unity;
    using Unity.Mvc5;

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentsBll, StudentsBll>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}