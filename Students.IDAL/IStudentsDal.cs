namespace Students.IDAL
{
    using Students.Models;
    using System;
    using System.Collections.Generic;

    public interface IStudentsDal
    {
        Tuple<int, IList<Student>> Students(int pageNumber, int pageSize, string sort);
    }
}
