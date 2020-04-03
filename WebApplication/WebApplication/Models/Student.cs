using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Student
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Studies { get; set; }
        public Enrollment enrollment { get; set; }
        public int IdStudent { get; set; }

    }
}

    