using Chain.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace Chain.Entities
{
    [Table("AppUsers")]
    public class AppUser:IdentityUser
    {
    }
}
