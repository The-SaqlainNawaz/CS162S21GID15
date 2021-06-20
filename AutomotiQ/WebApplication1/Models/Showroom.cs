using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Showroom
    {
        private static Showroom instance;

        public static Showroom getindtance()
        {
            if(instance==null)
            {
                return new Showroom();
            }
            else
            {
                return instance;
            }
        }
        private Showroom(){

            }
        public List<Dealer>dealers { get; set; }
        public List<Customer> customers { get; set; }
    }
}