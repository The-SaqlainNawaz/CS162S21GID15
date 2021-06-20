using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
       public abstract class Person
    {
        protected Person(string name, string cnic, string email, string contactnumber, string city, string id)
        {
            this.name = name;
            this.cnic = cnic;
            this.email = email;
            this.contactnumber = contactnumber;
            this.city = city;
            this.id = id;
            this.wallet = null;
        }
        protected Person()
        { }
        public string name { get; set; }
        public string cnic { get; set; }
          public string email { get; set; }
        public string contactnumber { get; set; }
        public string city { get; set; }
        
        public string id { get; set; }
        public Wallet wallet { get; set; }
    }
}