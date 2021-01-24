using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public GradeType GradeT { get; set; }
    }
}
