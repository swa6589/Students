namespace Students.DAL
{
    using Students.IDAL;
    using Students.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsDal : IStudentsDal
    {
        public Tuple<int, IList<Student>> Students(int pageNumber, int pageSize, string sort)
        {
            using (var context = new SchoolContext())
            {
                var sqlQuery = context.Students.SqlQuery("select * from Students order by " + sort).ToList();

                int take = pageSize;
                int skip = (pageNumber == 1) ? 0 : (pageNumber * pageSize) - pageSize;

                var result = new Tuple<int, IList<Student>>(sqlQuery.Count, sqlQuery.Skip(skip).Take(take).ToList<Student>());
                return result;
            }
        }
    }
}
