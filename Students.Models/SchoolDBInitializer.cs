namespace Students.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class SchoolDBInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            
        }
    }
}
