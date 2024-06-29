using System.ComponentModel.DataAnnotations;

namespace BookingProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {

        [Required(ErrorMessage = "Please enter the room number")]
        public required string RoomNumber { get; set; }

        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter the room title")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of bed")]
        public required string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathroom")]
        public required string BathCount { get; set; }

        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
