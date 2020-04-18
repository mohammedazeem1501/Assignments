using BlazorAdvance.Data.Models;
using BlazorAdvance.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Service
{
    public class SignupService :ISignup
    {
        public bool Insert(UserDetails userDetails)
        {
            try
            {
                using (var context = new StudentDBContext())
                {

                    context.UserDetails.Add(userDetails);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
