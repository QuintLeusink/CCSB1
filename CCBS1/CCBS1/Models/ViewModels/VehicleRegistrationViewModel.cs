using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCBS1.Models.ViewModels
{
    public class VehicleRegistrationViewModel
    {
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public int Length { get; set; }
        public bool PowereSupply { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string KindOfVehicle { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
