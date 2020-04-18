using BlazorAdvance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Repository
{
    interface ISignup
    {
        public bool Insert(UserDetails userDetails);
    }
}
