using System.ComponentModel.DataAnnotations;

namespace BookingProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Enter the Username")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Enter the Password")]
        public String Password { get; set; }
    }
}
