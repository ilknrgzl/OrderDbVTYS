using Core.DataAccess.Repository;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EF
{
	public class EFProductDal : EFProductRepository<Product, Context>, IProductDal
	{
		public EFProductDal(Context context) : base(context)
		{
		}
	}
}
