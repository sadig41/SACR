using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Relative
    {
        public int Id { get; set; }
        public PName Name { get; set; }
        public Address Address { get; set; }
        public string Mob { get; set; }
    }
}
