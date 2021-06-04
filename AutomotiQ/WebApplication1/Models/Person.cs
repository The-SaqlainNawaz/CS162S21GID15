using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        public string name { get; set; }
        public string cnic { get; set; }
        public string email { get; set; }
        public string contactnumber { get; set; }
        public string city { get; set; }
        public Wallet wallet { get; set; }
    }
}