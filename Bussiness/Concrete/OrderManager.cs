using DataAccess.Abstract;
using DataAccess;
using Entities;
using Bussiness.Abstract;
using Bussiness.ServicesResult;

namespace Bussiness.Concrete
{
	public class OrderManager : IOrderServices
	{
		private Context _context;
		private IOrderDal _orderDal;
		private IProductDal _productDal;
		public OrderManager(Context context, IOrderDal orderDal, IProductDal productDal)
		{
			_context = context;
			_orderDal = orderDal;
			_productDal = productDal;
		}

		public async Task<Order> AddOrder(Order order)
		{
			var mapToOrder = new Order
			{
				Id = order.Id,
				CreatedAt = DateTime.Now,
				OrderDate = order.OrderDate,
				ProductId = order.ProductId,
				Quantity = order.Quantity,

			};
			var result = await _orderDal.AddAsync(mapToOrder);
			return result;
		}

		public async Task<ServiceResult<List<Order>>> GetAllOrder()
		{
			var orders = await _orderDal.GetAllAsync();
			var mapToorders = orders.Select(x => new Order
			{
				Id = x.Id,
				CreatedAt = x.CreatedAt,
				UpdatedAt = x.UpdatedAt,
				Quantity = x.Quantity,
				ProductId = x.ProductId,
				OrderDate = x.OrderDate,

			}).ToList();

			return new ServiceResult<List<Order>> { Result = mapToorders, ResponseStatus = ResponseStatus.IsSuccess };
		}


		public async Task<Order> GetByIdOrder(int id)
		{
			var order = await _orderDal.GetByIdAsync(p => p.Id == id);

			if (order == null)
			{
				// Throw exception if no order is found with the given ID
				throw new Exception($"Böyle bir ürün bulunmadı: {id}");
			}

			return order; // Return the single order
		}


		public async Task<decimal> GetTotalOrderAmount()
		{
			var orders = await _orderDal.GetAllAsync();
			decimal totalAmount = 0;

			foreach (var order in orders)
			{
				var products = await _productDal.GetByIdAsync(p => p.Id == order.ProductId);


				if (products != null)
				{
					totalAmount += order.Quantity * products.Price; // Ürünün fiyatını kullan
				}
			}

			return totalAmount;
		}
	}
}






