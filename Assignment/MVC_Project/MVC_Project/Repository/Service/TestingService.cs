using MVC_Project.Models.EntityModels;
using MVC_Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Repository.Service
{
    public class TestingService : ITesting
    {
        public IEnumerable<Testing> GetDetails()
        {
            var context = new MVCEntities();
            var result = (from e in context.Testings select e).ToList();
            return result;

        }
    }
}