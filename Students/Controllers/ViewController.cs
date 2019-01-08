namespace Students.Controllers
{
    using Students.IBLL;
    using System;
    using System.Configuration;
    using System.Web.Mvc;

    public class ViewController : Controller
    {
        readonly IStudentsBll studentsBll;
        public ViewController(IStudentsBll students)
        {
            this.studentsBll = students;
        }

        // GET: View
        public ActionResult Index(int id = 1, string sort = "StudentName")
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
            var stu = studentsBll.Students(id, pageSize, sort);

           
            ViewBag.pageCount = (stu.Item1 % pageSize == 0 ) ? stu.Item1 / pageSize : (stu.Item1 / pageSize) + 1;
            return View(stu.Item2);
        }
    }
}