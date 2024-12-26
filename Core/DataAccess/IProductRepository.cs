using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	public interface IProductRepository<T> where T : class, IEntity, new()
	{
		Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
		Task<T> GetByIdAsync(Expression<Func<T, bool>> filter);
		Task<T> AddAsync(T entity);
		Task<bool> UpdateAsync(T entity);
		Task<bool> DeleteAsync(T entity);
	}
}
