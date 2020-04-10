using MVC_Project.Models.EntityModels;
using MVC_Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Repository.Service
{
    public class EmployeeService : IEmployee
    {
        public int AddEmployee(Employee employee)
        {
            using (var context = new MVCEntities())
            {
                Employee emp = new Employee()
                {
                    Emp_ID = employee.Emp_ID,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Designation = employee.Designation,
                    Competency = employee.Competency,
                    Experience = employee.Experience,
                    Salary = employee.Salary
                };

                context.Employees.Add(employee);
                context.SaveChanges();
                return emp.Emp_ID;
            }


        }
        public IEnumerable<Employee> GetEmployee()
        {
            var context = new MVCEntities();
            var result = (from e in context.Employees select e).ToList();
            return result;

        }

        public Employee GetEmployeeById(int id)
        {
            var context = new MVCEntities();
            var result = context.Employees.FirstOrDefault(x=>x.Emp_ID==id);
            return result;
        }
    }
}