using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain.Entities
{
    [Table("Suppliers")]
    public class Supplier : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string SupplierName { get; set; }
        [Required]
        [MaxLength(32)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(32)]
        public string Phone { get; set; }
    }
}
