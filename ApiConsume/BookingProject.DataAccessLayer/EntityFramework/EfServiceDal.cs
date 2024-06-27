using BookingProject.DataAccessLayer.Abstract;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.DataAccessLayer.Repositories;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.DataAccessLayer.EntityFramework
{
	public class EfServiceDal:GenericRepository<Service>, IServiceDal
	{
        public EfServiceDal(Context context):base(context) { }
        
    }
}
