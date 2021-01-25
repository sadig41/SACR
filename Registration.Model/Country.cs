using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class Country: NameBase
    {
        [Key]
        public int Id { get; set; }
    }
}