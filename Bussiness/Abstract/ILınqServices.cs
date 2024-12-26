using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ILınqServices
    {
        Task<List<Product>> GetAllPriceList();

        Task<List<Order>> GetAllOrderList();
        Task<List<Product>> GetAllStock();
        Task<List<Product>> GetAllDate(DateTime dateTime);
    }
}
