using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain.Entities
{
    [Table("Customers")]
    public class Customer:EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(32)]
        public string Email { get; set; }
        [Required]
        [MaxLength(32)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
    }
}
