using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Dealer:Person,OperatinsVehicle
    {
        public List<UsedVehicle> usedVehicles { get; set; }
        public List<NewVehicles> newVehicles { get; set; }
        public List<RentableVehicle> rentableVehicles { get; set; }
      
        public string collectionName { get; set; }
        public Cart hiscart { get; set; }
        public OperationParts operationParts { get; set; }
        public Cart cart { get; set; }

        public bool Caradd()
        {
            throw new NotImplementedException();
        }

        public bool editcar()
        {
            throw new NotImplementedException();
        }

        public bool removecar()
        {
            throw new NotImplementedException();
        }

        public bool viewcar()
        {
            throw new NotImplementedException();
        }
    }
}