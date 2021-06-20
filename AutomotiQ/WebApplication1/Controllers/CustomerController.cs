using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpPost]
        public bool UserSignup(Customer person)
        {
            CustomerTableEntities1 db = new CustomerTableEntities1();
            try
            {
                // StreamWriter writer = new StreamWriter("C:/BS Computer Science/Text.txt", true);
                //writer.WriteLine(person.name + "," + person.email);
                //writer.Flush();
                //writer.Close();
                Random rnd = new Random();
                int n=rnd.Next(1000);
                person.id = n.ToString();
                customerTable customer = new customerTable();
                customer.Name = person.name;
                customer.cnic = person.cnic;
                customer.email = person.email;
                customer.contnumber = person.contactnumber;
                customer.city = person.city;
                customer.id = person.id;
                
                db.customerTables.Add(customer);
                
                
            }
            
            catch (Exception ex)
            {
                return false;
            }
            db.SaveChanges();
            return true;
        }
        [HttpGet]
        public List<Customer> userSigupreterive()
        {
              List<Customer> customers = new List<Customer>();
            /*StreamReader reader = new StreamReader("C:/BS Computer Science/Text.txt");
            String line = reader.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                String[] arr = line.Split(',');
                Customer cu = new Customer();
                cu.name = arr[0];
                cu.email = arr[1];
                customers.Add(cu);
                line = reader.ReadLine();
            }
         */
            CustomerTableEntities usersInformationEntities = new CustomerTableEntities();
            var list = usersInformationEntities.customerTables.ToList();
                   foreach(var dbo in list)
                   {
                       Customer customer = new Customer();
                customer.email = dbo.email;
                customer.name = dbo.Name;
                customer.city = dbo.city;
                customer.id = dbo.id;
                customer.contactnumber = dbo.contnumber;
                customer.cnic = dbo.cnic;
                customer.cart = null;
                customer.wallet = null;
                customers.Add(customer);
                   }
            return customers;

        }
    }
}
