using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCBS1.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
    }
}
