using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain.Entities
{
    [Table("Orders")]
    public class Order : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public Guid? CustomerId { get; set; }
        //[Required]
        //[MaxLength(100)]
        //public Guid? ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(32)]
        public DateTime OrderDate { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }
        //[ForeignKey(nameof(ProductId))]
        //public Product Product { get; set; }

    }
}
