using System.Collections.Generic;
using WebApplication.DAL;
using WebApplication.Models;

namespace WebApplication.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent =1, FirstName= "Jan", LastName= "Kowalski"},

                new Student{IdStudent=2, FirstName = "Pawel", LastName = "Pawlowicz"},

                new Student{IdStudent=3, FirstName="Andrzej", LastName="Duda"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}