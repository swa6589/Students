namespace Students.BLL
{
    using Students.DAL;
    using Students.IBLL;
    using Students.IDAL;
    using Students.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StudentsBll : IStudentsBll
    {
        readonly IStudentsDal studentsDal;
        public StudentsBll()
        {
            this.studentsDal = new StudentsDal();
        }

        public Task<Tuple<int, IList<Student>>> Students(int pageNumber, int pageSize, string sort)
        {  
            return studentsDal.Students(pageNumber, pageSize, sort);
        }

        public Task<bool> Add(Student model)
        {
            return studentsDal.Add(model);
        }
    }
}
