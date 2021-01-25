using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class EAddress
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Website { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
    }
}