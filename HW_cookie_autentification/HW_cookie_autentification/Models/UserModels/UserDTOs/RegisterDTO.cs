using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_cookie_autentification.Models.UserModels.UserDTOs
{
    public class RegisterDTO
    {
        public string Email { get; set; } = null!;
        
        public string Password { get; set; } = null!;
       
        public string PasswordConfirm { get; set; } = null!;
        
        public string Role { get; set; } = null!;
    }
}
