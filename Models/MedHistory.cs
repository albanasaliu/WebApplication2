using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MedHistory
    {
        public int ID { get; set; }
        public string Xray { get; set; }
        public string Allergy { get; set; }
        public string CurrentHealth { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
