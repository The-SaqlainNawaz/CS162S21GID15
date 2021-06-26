using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class AdminAddVehiclesController : ApiController
    {
        
        [HttpPost]
        public bool AdminAddVeh(Vehicles veh)
        {
            AddVehicleEntities2 dbo = new AddVehicleEntities2();
            string s = veh.idno.ToString();
            try
            {
                AddVehicle vehic = new AddVehicle();
                vehic.VehicleName = veh.name;
                vehic.Color = veh.color;
                vehic.Price = veh.price;
                vehic.Model = veh.brand;
                vehic.Capacity = veh.enginecap;
                vehic.Category = veh.catagory;
                vehic.ID = s;
                vehic.Stck = veh.stck;
                dbo.AddVehicles.Add(vehic);    
            }
            catch (Exception ex)
            {
                return false;
            }
            dbo.SaveChanges();
            return true;
        }
        [HttpGet]
        public List<Vehicles> getVehiclesInfo()
        {
            List<Vehicles> Vehicles = new List<Vehicles>();
            AddVehicleEntities2 addVehicleEntities = new AddVehicleEntities2();
            var list = addVehicleEntities.AddVehicles.ToList();
            foreach(var dbo in list)
            {
                Vehicles v = new Vehicles();
                v.name = dbo.VehicleName;
                v.color = dbo.Color;
                v.price = dbo.Price;
                v.brand = dbo.Model;
                v.enginecap = dbo.Capacity;
                v.catagory = dbo.Category;
                v.idno = dbo.ID;
                v.stck = dbo.Stck;
                Vehicles.Add(v);
            }
            return Vehicles;
        }


    }
}
