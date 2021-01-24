using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public PName Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address BirthPlace { get; set; }
        public NatID NatID { get; set; }
        public Address Address { get; set; }
        public string Mob { get; set; }
        public EAddress EAddress { get; set; }

    }

    
}
