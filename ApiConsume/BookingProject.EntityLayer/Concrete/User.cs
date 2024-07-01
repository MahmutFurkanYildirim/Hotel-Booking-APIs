using Microsoft.AspNetCore.Identity;

namespace BookingProject.EntityLayer.Concrete
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
