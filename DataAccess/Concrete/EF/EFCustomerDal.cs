using Core.DataAccess.Repository;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EF
{
	public class EFCustomerDal : EFProductRepository<Customer, Context>, ICustomerDal
	{
		public EFCustomerDal(Context context) : base(context)
		{
		}
	}
}
