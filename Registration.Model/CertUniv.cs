using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class CertUniv
    {
        [Key]
        public int Id { get; set; }
        public Person Personel { get; set; }
        public Certification Certification { get; set; }

    }
}