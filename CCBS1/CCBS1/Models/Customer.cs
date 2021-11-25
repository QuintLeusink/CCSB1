using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCBS1.Models
{
    public class Customer
    {
        [DisplayName("Stad")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string City { get; set; }

        [DisplayName("Bank rekening")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string BankAccount { get; set; }

        [DisplayName("Postcode")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string PostalCode { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string Address { get; set; }

        //Navigation Property
        public ICollection<Vehicles> Vehicles { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public string UserName { get; internal set; }
    }
}
