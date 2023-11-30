using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository

    {
        private static List<Student> _students = new List<Student>
        {
            new Student{StudentId=1, Name="John Doe", Email="john@gmail.com", BirthDate= new DateOnly(2000, 2, 10)},
            new Student{StudentId=2, Name="Jane", Email="jane@gmail.com", BirthDate= new DateOnly(2001, 2, 10)},
            new Student{StudentId=3, Name="Jini", Email="jini@gmail.com", BirthDate= new DateOnly(2002, 2, 10)},
            new Student{StudentId=4, Name="Jono", Email="jono@gmail.com", BirthDate= new DateOnly(2003, 2, 10)},
        };

        new
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
           return _students.First(s => s.StudentId == id);
        }
    }
}