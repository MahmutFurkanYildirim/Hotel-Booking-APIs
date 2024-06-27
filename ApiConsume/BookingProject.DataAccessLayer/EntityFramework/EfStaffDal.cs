using BookingProject.DataAccessLayer.Abstract;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.DataAccessLayer.Repositories;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.DataAccessLayer.EntityFramework
{
	public class EfStaffDal:GenericRepository<Staff>, IStaffDal
	{
        public EfStaffDal(Context context):base(context)
        {
            
        }
    }
}
