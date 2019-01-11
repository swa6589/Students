namespace Students.IBLL
{
    using Students.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStudentsBll
    {
        Task<Tuple<int, IList<Student>>> Students(int pageNumber, int pageSize, string sort);

        Task<bool> Add(Student model);
    }
}
