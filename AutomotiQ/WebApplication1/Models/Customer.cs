using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer:Person
    {
        public Customer( string name, string cnic, string email, string contactnumber, string city, string id)
            : base(name, cnic, email, contactnumber, city, id)
        {
           
        }
        public Customer()
        {

        }
        public Cart cart { get; set; }
       
    }
}