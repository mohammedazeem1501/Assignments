using MVC_Project.Models.EntityModels;
using MVC_Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Repository.Service
{
    public class FrontendService : IFrontend
    {
        public IEnumerable<Frontend> GetDetails()
        {
            var context = new MVCEntities();
            var result = (from e in context.Frontends select e).ToList();
            return result;

        }
    }
}