namespace Students.Controllers
{
    using Students.IBLL;
    using Students.Models;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class ViewController : Controller
    {
        readonly IStudentsBll studentsBll;
        public ViewController(IStudentsBll students)
        {
            this.studentsBll = students;
        }

        // GET: View
        public async Task<ActionResult> Index(int id = 1, string sort = "StudentName")
        {
            var result = await StudentList(id, sort);
            return View(result);
        }

        private async Task<IList<Student>> StudentList(int id, string sort)
        {

            Task<IList<Student>> task = Task.Run(() =>
            {
                int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
                var stu = studentsBll.Students(id, pageSize, sort);
                ViewBag.pageCount = ((stu.Result.Item1 % pageSize == 0) ? stu.Result.Item1 / pageSize : (stu.Result.Item1 / pageSize) + 1);

                return stu.Result.Item2;
            });

            await task;
            return task.Result;
        }


        public ActionResult Create()
        {
            return View("Create", new Student());
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind(Exclude = "StudentId")]Student model)
        {

            await Task.Run(() =>
            {
                if (ModelState.IsValid)
                {
                    bool result = studentsBll.Add(model).Result;
                    ViewBag.ErrorMessage = result ? "Record Added successfully" : "Something went wrong could not added the record";
                }
            });

            var studentList = await StudentList(1, "StudentName");
            return View("Index", studentList);
        }
    }
}