using System.ComponentModel.DataAnnotations;

namespace HW_cookie_autentification.Models.UserModels.UserDTOs
{
    public class LoginDTO
    {
        public string Email { get; set; } = null!;
        
        public string Password { get; set; } = null!;
    }
}
