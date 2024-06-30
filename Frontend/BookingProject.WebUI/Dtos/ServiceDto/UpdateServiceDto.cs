using System.ComponentModel.DataAnnotations;

namespace BookingProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Please enter the icon")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        [StringLength(100, ErrorMessage = "You can enter a maximum of 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the description")]
        [StringLength(100, ErrorMessage = "You can enter a maximum of 500 characters")]
        public string Description { get; set; }
    }
}
