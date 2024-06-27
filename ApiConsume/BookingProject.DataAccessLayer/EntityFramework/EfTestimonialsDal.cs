using BookingProject.DataAccessLayer.Abstract;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.DataAccessLayer.Repositories;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.DataAccessLayer.EntityFramework
{
	public class EfTestimonialsDal:GenericRepository<Testimonial>, ITestimonialDal
	{
        public EfTestimonialsDal(Context context):base(context) { }
        
    }
}
