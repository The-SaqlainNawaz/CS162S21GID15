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
            try
            {
                // StreamWriter writer = new StreamWriter("C:/BS Computer Science/Text.txt", true);
                //writer.WriteLine(person.name + "," + person.email);
                //writer.Flush();
                //writer.Close();

                CustomerTableEntities db = new CustomerTableEntities();
                customerTable customer = new customerTable();
                customer.Name = person.name;
                customer.email = person.email;
                customer.cnic = person.cnic;
                customer.city = person.city;
                customer.id = person.id;
                customer.contnumber = person.contactnumber;
                db.customerTables.Add(customer);
                db.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
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
                       customers.Add(customer);
                   }
            return customers;

        }
    }
}
