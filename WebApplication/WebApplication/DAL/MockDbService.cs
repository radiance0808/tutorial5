using System;
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
                new Student{IndexNumber = $"s{new Random().Next(1, 2000)}", FirstName= "Jan", LastName= "Kowalski"},

                new Student{IndexNumber = $"s{new Random().Next(1, 2000)}", FirstName = "Anna", LastName = "Malewski"},

                new Student{IndexNumber = $"s{new Random().Next(1, 2000)}", FirstName="Andrzej", LastName="Andrzejewicz"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
