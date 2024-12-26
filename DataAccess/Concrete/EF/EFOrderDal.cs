using Core.DataAccess.Repository;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EF
{
	public class EFOrderDal : EFProductRepository<Order, Context>, IOrderDal
	{
		public EFOrderDal(Context context) : base(context)
		{
		}
	}
}
