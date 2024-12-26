using Bussiness.ServicesResult;
using Entities;

namespace Bussiness.Abstract
{
	public interface IOrderServices
	{
		Task<Order> AddOrder(Order order);
		Task<Order> GetByIdOrder(int id);
		Task<ServiceResult<List<Order>>> GetAllOrder();
		Task<decimal> GetTotalOrderAmount();
	}
}
