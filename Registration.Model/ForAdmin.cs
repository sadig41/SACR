using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class ForAdmin
    {
        [Key]
        public int Id { get; set; }
        public string RecipeNo { get; set; }
        public DateTime RecipeDate { get; set; }
        public Decimal Amount { get; set; }
        public PName Accounter { get; set; }
        public RecType Type { get; set; }
    }
}
