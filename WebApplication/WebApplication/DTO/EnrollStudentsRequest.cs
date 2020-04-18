using System;
using System.ComponentModel.DataAnnotations;
using WebApplication.Models;

namespace WebApplication.DTO
{
    public class EnrollStudentRequests
    {
        [Required]
        [RegularExpression("^s[0-9]+$")]
        public string IndexNumber { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression("^a-zA-Z+$")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression("^a-zA-Z+$")]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Studies studies { get; set; }

    }
}
