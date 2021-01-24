using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class Address
    {
        
        public int Id { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public province Provenc { get; set; }
        public Village Village { get; set; }
        public string Street { get; set; }
    }
}