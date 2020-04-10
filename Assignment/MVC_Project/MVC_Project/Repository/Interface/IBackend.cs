using MVC_Project.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Repository.Interface
{
    interface IBackend
    {
        IEnumerable<Backend> GetDetails();
    }
}
