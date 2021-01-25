using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class Department:NameBase
    {
        [Key]
        public int Id { get; set; }
        public Colleage Colleage { get; set; }
       
    }
}