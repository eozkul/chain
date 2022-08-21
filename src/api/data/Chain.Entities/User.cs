using Chain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain.Entities
{
    [Table("Users")]
    public class User:EntityBase
    {
        [MaxLength(64)]
        [Required]
        public string UserName { get; set; }
        [Required]
        [MaxLength(64)]
        public string Email { get; set; }
        [MaxLength(64)]
        public string Department { get; set; }
        [MaxLength(64)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(64)]
        public string Position { get; set; }
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }
        [Required]
        public UserType UserType { get; set; }
     
    }
}
