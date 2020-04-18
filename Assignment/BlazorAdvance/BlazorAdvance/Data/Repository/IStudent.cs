using BlazorAdvance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Repository
{
    interface IStudent
    {
        public List<Student> GetStudent();
        public Student GetStudentById(int id);
        public bool Insert(Student student);
        public bool Update(Student student);
        public bool Delete(Student student);
    }
}
