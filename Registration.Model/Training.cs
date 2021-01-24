using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        public string TrainingCenter { get; set; }
        public DateTime TrainingFrom { get; set; }
        public DateTime TrainingTo { get; set; }
        public string Field { get; set; }  // Field of training
    }
}
