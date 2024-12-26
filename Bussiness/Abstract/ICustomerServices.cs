using Bussiness.ServicesResult;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
	public interface ICustomerServices
	{
		Task<ServiceResult<List<Customer>>> GetAllCustomer();
		Task<Customer> AddCustomer(Customer customer);
	}
}
