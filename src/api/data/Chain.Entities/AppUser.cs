using Chain.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace Chain.Entities
{
    [Table("AppUsers")]
    public class AppUser:IdentityUser
    {
        public Guid AppUserId { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
