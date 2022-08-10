using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain.Entities
{
    [Table("Categories")]
    public class Category : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }
        [MaxLength(100)]
        public int Description { get; set; }

    }
}
