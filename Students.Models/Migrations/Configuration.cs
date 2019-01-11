namespace Students.Models.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Students.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Students.Models.SchoolContext";
        }

        protected override void Seed(Students.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var students = new List<Student>();

            students.Add(new Student() { StudentID = 1, StudentName = "Alias", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 2, StudentName = "Bishop", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 3, StudentName = "Cyngy", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });
            students.Add(new Student() { StudentID = 4, StudentName = "Dais", Address = "Chikpet", DateOfBirth = Convert.ToDateTime("11/14/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 5, StudentName = "Elia", Address = "Madiwala", DateOfBirth = Convert.ToDateTime("11/16/2014"), standard = 2 });

            students.Add(new Student() { StudentID = 6, StudentName = "Faiz", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 7, StudentName = "Gian", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 8, StudentName = "Hian", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });
            students.Add(new Student() { StudentID = 9, StudentName = "Ial", Address = "Chikpet", DateOfBirth = Convert.ToDateTime("11/14/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 10, StudentName = "Jack", Address = "Madiwala", DateOfBirth = Convert.ToDateTime("11/16/2014"), standard = 2 });

            students.Add(new Student() { StudentID = 11, StudentName = "Kite", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 12, StudentName = "Lape", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 13, StudentName = "Mane", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });
            students.Add(new Student() { StudentID = 14, StudentName = "Nare", Address = "Chikpet", DateOfBirth = Convert.ToDateTime("11/14/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 15, StudentName = "Ore", Address = "Madiwala", DateOfBirth = Convert.ToDateTime("11/16/2014"), standard = 2 });

            students.Add(new Student() { StudentID = 16, StudentName = "Pasti", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 17, StudentName = "Quer", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 18, StudentName = "Rony", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });
            students.Add(new Student() { StudentID = 19, StudentName = "Sost", Address = "Chikpet", DateOfBirth = Convert.ToDateTime("11/14/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 20, StudentName = "Tony", Address = "Madiwala", DateOfBirth = Convert.ToDateTime("11/16/2014"), standard = 2 });

            students.Add(new Student() { StudentID = 21, StudentName = "Uary", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 22, StudentName = "Vane", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 23, StudentName = "Wary", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });
            students.Add(new Student() { StudentID = 24, StudentName = "Xan", Address = "Chikpet", DateOfBirth = Convert.ToDateTime("11/14/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 25, StudentName = "Yane", Address = "Madiwala", DateOfBirth = Convert.ToDateTime("11/16/2014"), standard = 2 });

            students.Add(new Student() { StudentID = 26, StudentName = "Zest", Address = "Ecity", DateOfBirth = Convert.ToDateTime("11/11/2014"), standard = 1 });
            students.Add(new Student() { StudentID = 27, StudentName = "Bishop", Address = "Hoskur", DateOfBirth = Convert.ToDateTime("11/20/2014"), standard = 2 });
            students.Add(new Student() { StudentID = 28, StudentName = "Cyngy", Address = "Penia", DateOfBirth = Convert.ToDateTime("11/12/2014"), standard = 3 });

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();



        }
    }
}
