using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Register
    {
        public int Id { get; set; }
        public string AgrID { get; set; }
        public Person Person { get; set; }
        public Experinces WorkingHistory { get; set; }
        public Training Experince { get; set; }
        public Relative Relative { get; set; }
        public ForAdmin ForAdmin { get; set; }
        public virtual ICollection<Certification> Certificate { get; set; }
        public virtual ICollection<Paper> Paper { get; set; }
        public DateTime RegDate { get; set; }
        public virtual ICollection<Classification> Classification { get; set; }   // Classification
        public Grade Grade { get; set; }  // Grade
    }
}
