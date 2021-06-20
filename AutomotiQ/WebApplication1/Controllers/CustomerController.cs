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

                TestkrnahbhaijanydeEntities db = new TestkrnahbhaijanydeEntities();
                test customer = new test();
                customer.Uername = person.name;
                customer.Email = person.email;
                db.tests.Add(customer);
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
            TestkrnahbhaijanydeEntities usersInformationEntities = new TestkrnahbhaijanydeEntities();
            var list = usersInformationEntities.tests.ToList();
                   foreach(var dbo in list)
                   {
                       Customer customer = new Customer();
                customer.email = dbo.Email;
                customer.name = dbo.Uername;
                       customers.Add(customer);
                   }
            return customers;

        }
    }
}
