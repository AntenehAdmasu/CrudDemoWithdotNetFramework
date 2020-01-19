using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkuDesigns.Models
{
    class Appointment
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public double PaidAmount { get; set; }
        public double RemainingAmount { get; set; }
        public String AppointmentDate { get; set; }

    }
}
