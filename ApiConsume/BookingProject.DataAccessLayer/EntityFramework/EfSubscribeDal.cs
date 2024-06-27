using BookingProject.DataAccessLayer.Abstract;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.DataAccessLayer.Repositories;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.DataAccessLayer.EntityFramework
{
	public class EfSubscribeDal:GenericRepository<Subscribe>, ISubscribeDal
	{
		public EfSubscribeDal(Context context):base(context)
		{
			
		}
	}
}
