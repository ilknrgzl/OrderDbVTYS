using Bussiness.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apı.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LınqController : ControllerBase
    {
            ILınqServices _lınqServices;
            ICustomerServices _customerServices;
            public LınqController(ILınqServices lınqServices, ICustomerServices customerServices)
            {
                _lınqServices = lınqServices;
                _customerServices = customerServices;
            }
            [HttpGet("GetAllPriceList")]
            public async Task<List<Product>> GetAllPriceList()
            {
                var models = await _lınqServices.GetAllPriceList();
                return models;
            }
            [HttpGet("GetAllOrderList")]
            public async Task<List<Order>> GetAllOrderList()
            {
                var models = await _lınqServices.GetAllOrderList();
                return models;
            }
            [HttpGet("GetAllStock")]
            public async Task<List<Product>> GetAllStock()
            {
                var models = await _lınqServices.GetAllStock();
                return models;
            }
            [HttpPost("GetAllDate")]
            public async Task<List<Product>> GetAllDate([FromBody] DateTime dateTime)
            {
                var models = await _lınqServices.GetAllDate(dateTime);
                return models;
            }

    }
}
