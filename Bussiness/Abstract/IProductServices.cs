using Bussiness.ServicesResult;
using Entities;

namespace Bussiness.Abstract
{
	public interface IProductServices
	{
		Task<ServiceResult<List<Product>>> GetAllProduct();
		Task<Product> GetByIdAsync(int id);
		Task<Product> AddProduct(Product product);
		Task<bool> UpdateProduct(int id);
		Task<bool> DeleteProduct(int id);
	}
}
