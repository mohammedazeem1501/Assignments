using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Token_Generation.Models;

namespace Token_Generation.Data
{
    public class Token_Generate : IToken_Generate
    {
      
        public IConfiguration _config;

        public Token_Generate(IConfiguration config)
        {
            _config = config;
        }

        private LoginDetails GetUser(string username, string password,string role)
        {
            var _context = new TokenDBContext();
            return _context.LoginDetails.FirstOrDefault(u => u.UserName == username && u.Password == password && u.Role == role);
        }
        public string Generate_Token(LoginDetails login)
        {
            
            var user = GetUser(login.UserName, login.Password,login.Role);  // username = Admin / Azeem && password = pass
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Role,login.Role) // role = admin/user
                   
                };
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddSeconds(60),
                signingCredentials: credentials);

                return (new JwtSecurityTokenHandler().WriteToken(token));  


            }
            else
            {
                return("Something Went Wrong.................@@!!!!!");
            }


        }
    }
}
