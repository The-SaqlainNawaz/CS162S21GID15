using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        //public customer(string name, string cnic, string email, string contactnumber, string city, string id)
        //    : base(name, cnic, email, contactnumber, city, id)
        //{

        //}
        public Customer()
        {

        }
        public string name { get; set; }
        public string cnic { get; set; }
        public string email { get; set; }
        public string contactnumber { get; set; }
        public string city { get; set; }
        public Wallet wallet { get; set; }
        public string id { get; set; }
        public Cart cart { get; set; }
       
    }
}