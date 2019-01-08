namespace Students.Models
{
    using System.Data.Entity;

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDBCodeFirst")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }
        
        public DbSet<Student> Students { get; set; }
    }
}

