using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api_FrameWork.Data;
using Web_Api_FrameWork.Models;

namespace Web_Api_FrameWork.Controllers
{
    public class IndexController : ApiController
    {
        // creating an instance of the model class
        StudentModel student = new StudentModel();


        // creating an instance of the data class
        StudentData studentdata = new StudentData();
        

        [HttpGet]
        public IHttpActionResult GetData() // method that displays the whole table
        {
            DataSet ds = studentdata.GetData();
            return Ok(ds);
        }

        [HttpGet]
        public IHttpActionResult GetData(int id) // method to display a single student record
        {
            DataSet ds = studentdata.GetData(id);
            return Ok(ds);
        }

        [HttpPost]
        public IHttpActionResult InsertData(StudentModel student) // method to insert a student record
        {
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = studentdata.InsertData(student);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPut]
        public IHttpActionResult UpdateData(int id, [FromBody]StudentModel student) // method to update a student record
        {
            //Student student = new Student();
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }
                bool result = studentdata.UpdateData(id, student);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "unable to update data" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteData(int id) //method to delete a student record
        {

            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }
                bool result = studentdata.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Something went wrong" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //[Route("api/index/GetData")]

        //public string GetDetails()
        //{
        //    return "Welcome to Web API";
        //}

        //[Route("api/index/GetValues")]

        //public string GetValues()
        //{
        //    return "Get values method"; ;
        //}

    }
}

