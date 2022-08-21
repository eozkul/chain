using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Chain.Common
{
    public class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
