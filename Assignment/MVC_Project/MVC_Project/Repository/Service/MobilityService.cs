using MVC_Project.Models.EntityModels;
using MVC_Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Repository.Service
{
    public class MobilityService : IMobility
    {
        public IEnumerable<Mobility> GetDetails()
        {
            var context = new MVCEntities();
            var result = (from e in context.Mobilities select e).ToList();
            return result;

        }
    }
}