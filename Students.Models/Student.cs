namespace Students.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Required(ErrorMessage = "Student Id is required")]
        public int StudentID { get; set; }

        [StringLength(maximumLength:100, MinimumLength =2, ErrorMessage = "Student name length does not match")]
        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }
       
        [Range(1, 10, ErrorMessage = "Standard needs to in between of 1 and 10")]
        public int standard { get; set; }

        public string Address { get; set; }
    }
}
