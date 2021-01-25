using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class Colleage:NameBase
    {
        [Key]
        public int Id { get; set; }
        public University University { get; set; }

    }
}