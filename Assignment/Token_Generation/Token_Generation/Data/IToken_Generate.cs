using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Token_Generation.Models;

namespace Token_Generation.Data
{
    public interface IToken_Generate
    {

       string Generate_Token(LoginDetails details);
    }
}
