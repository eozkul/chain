using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Chain.Entities
{
    [Table("Products")]
    public class Product : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string ProductName { get; set; }
        //public Guid? SupplierId { get; set; }
        public Guid? CategoryId { get; set; }
        //[ForeignKey(nameof(SupplierId))]
        //public Supplier Supplier { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public Color Color { get; set; }
        public Dimension Dimension { get; set; }
        public int Stock { get; set; }
    }
}
