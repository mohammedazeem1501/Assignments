using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Entity_DB_First_Core.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity_DB_First_Core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
       
        // this method shows the data of all the customers with their respective order details ... !!
        [HttpGet]
        public IActionResult getter()
        {
            var context = new ShopDBContext();
            try
            {
                var result = context.Customer.Include(s => s.Orders).ToList(); // linq query to perform join operation between
                return Ok(result);                                            // the customer and the orders table...!! using include()
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    

        //this method will accept one parameter from the url as the "customer ID" i.e. 101,102,103,104,105
        [HttpGet("{id}")]
        public IActionResult getter(int id) 
        {
            var context = new ShopDBContext();
            try
            {
                // linq query to perform join between three tables...!! using include() and thenInclude()...!!
                var list = context.Customer.Where(c => c.Id == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
                return Ok(list); // it will show the relation between three table for a particular customer.
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // this method will insert the values in the customer table as well as the orders table
        // and it will fetch the customer ID into order table automatically ..No need to provide customer ID in orders table..!!
        [HttpPost]
        public IActionResult Insert(Customer customer)
        {
            var context = new ShopDBContext();
            context.Customer.Add(customer); 
            context.SaveChanges();
            return Ok("Rows Inserted Successfully");
        }
      

        // this method will update the orders table according to their customer ID
        [HttpPut("{id}")]
        public IActionResult Update(int id, Orders order)
        {
            var context = new ShopDBContext();
            var std = context.Orders.FirstOrDefault(s => s.CustomerId == id); // it will accept parameter as CustomerID
            std.Amount = order.Amount;                                       // and will update its amount as passed in the body
            context.SaveChanges();
            return Ok("Row Updated Successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderAndCustomer( int id) // accepts the CustomerId as parameter and will delete
        {                                                    // the order and the customer synchronously.
            var context = new ShopDBContext();
            
            var std = context.Orders.FirstOrDefault(s => s.CustomerId == id); // delete from order table.
            context.Orders.Remove(std);
            var std1 = context.Customer.FirstOrDefault(c => c.Id == id); // delete from the customer table.
            context.Customer.Remove(std1);
            context.SaveChanges();
            return Ok("Row Deleted Successfully from the Orders and the Customer table ...!!");
        }


    }
}