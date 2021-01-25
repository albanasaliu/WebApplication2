using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfApp { get; set; }
        public Patient Patient { get; set; }
    }
}
