using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Certification
    {
        [Key]
        public int id { get; set; }
        public string CertName { get; set; }
        public Colleage Colleage { get; set; }
        public Department Department { get; set; }
        public Major Specialist { get; set; }
        public University University { get; set; } // Qualification and study field
        public DateTime CertDate { get; set; } // Qualification Date

    }
}
