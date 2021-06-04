using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Showroom
    {
        public List<Dealer>dealers { get; set; }
        public List<Customer> customers { get; set; }
    }
}