namespace WebApplication.Models
{
    public class Enrollment
    {
        public int IdSemester { get; set; }
        public string StartDate { get; set; }
        public Studies studies { get; set; }
    }
}
