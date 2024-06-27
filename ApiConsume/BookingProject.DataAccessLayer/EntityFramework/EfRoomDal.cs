using BookingProject.DataAccessLayer.Abstract;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.DataAccessLayer.Repositories;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.DataAccessLayer.EntityFramework
{
	public class EfRoomDal:GenericRepository<Room>, IRoomDal
	{
        public EfRoomDal(Context context):base(context) { }
        
    }
}
