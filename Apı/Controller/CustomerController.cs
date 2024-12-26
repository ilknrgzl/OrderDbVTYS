using Bussiness.Abstract;
using Bussiness.ServicesResult;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apı.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private ICustomerServices _customerServices;
		public CustomerController(ICustomerServices customerServices)
		{
			_customerServices = customerServices;
		}
		[HttpGet("GetAllCustomer")]
		public async Task<ServiceResult<List<Customer>>> GetAllCustomer()
		{
			var models = await _customerServices.GetAllCustomer();
			return models;
		}
		[HttpPost("AddCustomer")]
		public async Task<Customer> AddCustomer(Customer customer)
		{
			var addModel = await _customerServices.AddCustomer(customer);
			return addModel;
		}
	}
}
