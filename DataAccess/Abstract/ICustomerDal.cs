using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
	public interface ICustomerDal : IProductRepository<Customer>
	{
	}
}
