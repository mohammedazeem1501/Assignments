using BlazorAdvance.Data.Models;
using BlazorAdvance.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Service
{
    public class StudentService :IStudent
    {
        public List<Student> GetStudent()
        {
            try
            {
                using (var context = new StudentDBContext())
                {
                    var list = context.Student.ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Student GetStudentById(int id)
        {
            try
            {
                using (var context = new StudentDBContext())
                {

                    Student employee = context.Student.FirstOrDefault(e => e.Id == id);
                    return employee;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Student student)
        {
            try
            {
                using (var context = new StudentDBContext())
                {

                    context.Student.Add(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Student student)
        {
            try
            {

                using (var context = new StudentDBContext())
                {
                    context.Student.Update(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(Student student)
        {
            try
            {

                using (var context = new StudentDBContext())
                {
                    context.Student.Remove(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
