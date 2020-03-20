using Entity_DB_First_Core.Models;
using Entity_DB_First_Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_DB_First_Core.Data
{
    public class Opration : IOperation
    {


        public IEnumerable<Customer> GetAllCustomerData()
        {
            var context = new ShopDBContext();
            var list = context.Customer.Include(s => s.Orders).ToList();
            return(list);

        }

        
        public IEnumerable<Customer> GetCustomerDataById(int id)
        {
            var context = new ShopDBContext();

            var list = context.Customer.Where(c => c.Id == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
            return (list);
        }



    }
}
