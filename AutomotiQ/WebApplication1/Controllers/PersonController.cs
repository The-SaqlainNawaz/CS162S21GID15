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
    public class PersonController : ApiController
    {
        [HttpPost]
        public bool UserSignup(Customer person)
        {
            try
            {
              /*  StreamWriter writer = new StreamWriter("C:/BS Computer Science/Text.txt", true);
                writer.WriteLine(person.name + "," + person.email);
                writer.Flush();
                writer.Close();
                return true;*/
                UsersInformationEntities db = new UsersInformationEntities();
                User person1 = new User();
                person1.Name = person.name;
                person1.E_mail = person.email;
                person1.CNIC = person.cnic;
                person1.City = person.city;
                person1.ID = person.id;
                person1.Contact_Number = person.contactnumber;
                db.Users.Add(person1);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpGet]
        public  List<Customer> userSigupreterive()
        {

            /*  StreamReader reader = new StreamReader("C:/BS Computer Science/Text.txt");
              String line = reader.ReadLine();
              while(String.IsNullOrEmpty(line))
              {
                  String[] arr = line.Split(',');
                  Customer cu = new Customer();
                  cu.name = arr[0];
                  cu.email = arr[1];
                  line = reader.ReadLine();
              }*/
            List<Customer> customers = new List<Customer>();
            UsersInformationEntities usersInformationEntities = new UsersInformationEntities();
             var list = usersInformationEntities.Users.ToList();
             foreach(var dbo in list)
             {
                 //Customer customer = new Customer(dbo.Name,dbo.CNIC,dbo.E_mail,dbo.Contact_Number,dbo.City,dbo.ID);
                 //customers.Add(customer);
           
             }
            return customers;
        }
    }
}
