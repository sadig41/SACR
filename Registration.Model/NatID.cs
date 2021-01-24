using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Model
{
    public class NatID
    {
        [Key]
        public string ID { get; set; } // National Number
        public DateTime IssueDate { get; set; }
        public Address IssuePlace { get; set; }
        public NatType IdType { get; set; }
    }
}