namespace Students.Models
{
    using System.Data.Entity;

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Data Source=INL-427TGC2;Initial Catalog=Students;Persist Security Info=True;User ID=sa;Password=sS234@#$;Pooling=False")
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
        }
        
        public DbSet<Student> Students { get; set; }
    }
}

