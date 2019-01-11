namespace Students.DAL
{
    using Students.IDAL;
    using Students.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class StudentsDal : IStudentsDal
    {
        public async Task<Tuple<int, IList<Student>>> Students(int pageNumber, int pageSize, string sort)
        {
            using (var context = new SchoolContext())
            {
                Task<Tuple<int, IList<Student>>> result = null;
                try
                {

                    var sqlQuery = context.Students.ToList();

                    int take = pageSize;
                    int skip = (pageNumber == 1) ? 0 : (pageNumber * pageSize) - pageSize;
                    var orderList = OrderListAsync(sort, sqlQuery).GetAwaiter().GetResult();
                    int count = sqlQuery.Count();
                    result = Task.Run(() =>  new Tuple<int, IList<Student>>(count, orderList.AsEnumerable().Skip(skip).Take(take).ToList<Student>()));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                await result;
                return result.Result;
            }
        }

        private async Task<IList<Student>> OrderListAsync(string sort, IList<Student> students)
        {
            Task<List<Student>> studentsList;
           
                switch (sort)
                {
                    case "DateOfBirth":
                        studentsList = Task.Run(() => students.OrderBy(x => x.DateOfBirth).ToList());
                        break;

                    case "Address":
                        studentsList = Task.Run(() => students.OrderBy(x => x.Address).ToList());
                        break;

                    case "standard":
                        studentsList = Task.Run(() => students.OrderBy(x => x.standard).ToList());
                        break;

                    default:
                        studentsList = Task.Run(() => students.OrderBy(x => x.StudentName).ToList());
                        break;

                }

            await studentsList;
            return studentsList.Result;
        }

        public Task<bool> Add(Student model)
        {
            Task<bool> result = Task.FromResult(false); 
            using (var context = new SchoolContext())
            {
                try
                {
                    model.StudentID = context.Students.OrderByDescending(x => x.StudentID).First().StudentID + 1;
                    context.Students.Add(model);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    result = Task.FromResult(false); 
                }
                finally
                {
                    result = Task.FromResult(true); 
                }
            }

            return result;
        }
    }
}
