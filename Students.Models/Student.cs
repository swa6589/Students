namespace Students.Models
{
    using System;

    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }
       
        public int standard { get; set; }

        public string Address { get; set; }
    }
}
