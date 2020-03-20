using entity_advance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace entity_advance.Controllers
{
    public class IndexController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Insert(Customer customer) // this method will insert the data from the JSON body
        {                                                  // and insert into all 3 tables...!~!
            var context = new ShoppingDBContext();
            try
            {

                context.Customer.Add(customer);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok("Inserted Successfully");
        }

        [HttpGet]
        public IHttpActionResult Getter()
        {                                       // this method will get all the data from tables and show in the following format...!~
            try
            {
                var context = new ShoppingDBContext();
                var result = from s in context.Customer join o in context.Orders on s.CustomerId equals o.CustomerId
                             select new
                             {
                                 Customerid = s.CustomerId,
                                 firstName = s.FirstName,
                                 secondName = s.SecondName,
                                 Phone = s.PhoneNo,
                                 orderId = o.OrderId
                             };
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        public IHttpActionResult GetById(int id) // this method will show the data of any particular customer ID from all 3 tables...!
        {
            try
            {
                var context = new ShoppingDBContext();
                var list = context.Customer.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
                return Ok(list);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPut]
        public IHttpActionResult Update(int id, Orders order)
        {
            var context = new ShoppingDBContext();
            try
            {
                var std = context.Orders.FirstOrDefault(s => s.CustomerId == id); // it will accept parameter as CustomerID
                std.ProductId = order.ProductId;                                  // and will update its productID as passed in the body
                context.SaveChanges();
                return Ok("Row Updated Successfully");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpDelete]
        public IHttpActionResult DeleteById(int id) // this method will delete the data from the orders and customer table...!!!@!@
        {
            try
            {
                using (var context = new ShoppingDBContext())
                {
                    var std1 = context.Orders.FirstOrDefault(q => q.CustomerId == id);
                    context.Orders.Remove(std1);
                    var std = context.Customer.FirstOrDefault(s => s.CustomerId == id);
                    context.Customer.Remove(std);
                    context.SaveChanges();

                }
                return Ok("Data deleted Successfully from both the tables...!!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
