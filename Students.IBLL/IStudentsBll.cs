namespace Students.IBLL
{
    using Students.Models;
    using System;
    using System.Collections.Generic;

    public interface IStudentsBll
    {
        Tuple<int, IList<Student>> Students(int pageNumber, int pageSize, string sort);
    }
}
