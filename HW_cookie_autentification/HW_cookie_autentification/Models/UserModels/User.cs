using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW_cookie_autentification.Models.UserModels
{
    public class User
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        [Phone]
        public string? Phone { get; set;}
        public string Role { get; set; } = null!;
    }
}
