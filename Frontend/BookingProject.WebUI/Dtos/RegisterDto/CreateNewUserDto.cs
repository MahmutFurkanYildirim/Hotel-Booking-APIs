using System.ComponentModel.DataAnnotations;

namespace BookingProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname field is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Username field is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "City field is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirm field is required")]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
