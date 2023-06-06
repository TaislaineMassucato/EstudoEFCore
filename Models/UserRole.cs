using System.ComponentModel.DataAnnotations.Schema;


namespace EFCore.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        public int UserId { get; set; }
        public int UserRoleId { get; set; }    
    }
}