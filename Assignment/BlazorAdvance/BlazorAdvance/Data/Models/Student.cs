using System;
using System.Collections.Generic;

namespace BlazorAdvance.Data.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
    }
}
