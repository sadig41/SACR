using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Paper
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Field { get; set; }
        public DateTime PublishDate { get; set; }
        public string Journal { get; set; }
        public virtual ICollection<Register> Register { get; set; }
    }
}
