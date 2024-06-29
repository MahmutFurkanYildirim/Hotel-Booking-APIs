using System.ComponentModel.DataAnnotations;

namespace BookingProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Please enter the room number")]
        public required string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please enter the room image")]
        public required string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter the room title")]
        [StringLength(100, ErrorMessage = "You can enter a maximum of 100 characters")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of bed")]
        public required string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathroom")]
        public required string BathCount { get; set; }

        public string? Wifi { get; set; }

        [Required(ErrorMessage = "Please enter the description")]
        public required string Description { get; set; }
    }
}
