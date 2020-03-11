using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_CORE.Data;
using API_CORE.Model;
using System.Data;


namespace API_CORE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IStudent _data;

        public IndexController(IStudent data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetData()
        {

            DataSet ds = _data.GetData();
            return Ok(ds);
        }

        [HttpGet("{id}")]
        public IActionResult GetDataId(int id)
        {
            DataSet ds = _data.GetDataId(id);
            return Ok(ds);
        }

        [HttpPost]
        public ActionResult<bool> InsertData(Student student)
        {

            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.InsertData(student);
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

        [HttpPut("{id}")]
        public ActionResult<bool> UpdateData(int id, Student student)
        {

            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.UpdateData(id, student);
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

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteData(int id)
        {

            Student student = new Student();

            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.DeleteData(id);
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
    }
}