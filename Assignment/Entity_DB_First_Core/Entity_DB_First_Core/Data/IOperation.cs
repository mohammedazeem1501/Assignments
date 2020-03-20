using Entity_DB_First_Core.Models;
using Entity_DB_First_Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_DB_First_Core.Data
{
    public interface IOperation
    {

        public IEnumerable<Customer> GetAllCustomerData();
        public IEnumerable<Customer> GetCustomerDataById(int id);
        //public List<CustomerOrderViewModel> Getter();
        // DataSet GetAllCustomerData();
        //DataSet GetDataId(int id);
        //bool InsertData(Model.Student student);
        //bool UpdateData(int id, Model.Student student);
        //bool DeleteData(int id);
    }
}
