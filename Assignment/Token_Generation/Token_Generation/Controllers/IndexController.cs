using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Token_Generation.Data;
using Token_Generation.Models;

namespace Token_Generation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IToken_Generate _Generate;
        public IndexController(IToken_Generate token_Generate)
        {
            _Generate = token_Generate;
        }

        [HttpPost]
        public IActionResult Token(LoginDetails details)
        {
            try
            {
                return Ok(_Generate.Generate_Token(details));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string result = "hey, this is the Get()";
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IActionResult GetCommon()
        {

            try
            {
                return Ok("Hey , this method can be invoked without any authorization...........!!!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")] // role se bulaya hai .
        public IActionResult GetADmin()
        {
            try
            {

                return Ok("Hey, Welcome... admin....!!! ");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "user")] // role se bulaya hai .
        public IActionResult GetUser()
        {

            try
            {
                return Ok("Hey, Welcome ....You have Logged In as User ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





    }
}