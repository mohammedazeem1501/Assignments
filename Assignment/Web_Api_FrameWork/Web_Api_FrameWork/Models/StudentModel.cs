using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api_FrameWork.Models
{
    public class StudentModel
    {
        // creating a model class for making a replica of the database table............//
        public int Roll_No { get; set; }
        public string NAME { get; set; }
        public int MARKS { get; set; }

    }
}