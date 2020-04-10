using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Basic.Models
{
    public class StudentService : IStudent
    {
        readonly IEnumerable<Student> student;

        public StudentService()
        {
            student = new List<Student>
            { 
                new Student{Roll_No = 1, Name="Azeem",Address="Delhi"},
                new Student{Roll_No = 2, Name="Arpit",Address="Noida"},
                new Student{Roll_No = 3, Name="Vijay",Address="Delhi"},
                new Student{Roll_No = 4, Name="Vishesh",Address="Delhi"},
                new Student{Roll_No = 5, Name="Abhishek",Address="Allahabad"}   
            };
        }
        public IEnumerable<Student> GetStudent()
        {
            return student;
        }
        public void Save(Student student)
        {
           
        }
    }
}