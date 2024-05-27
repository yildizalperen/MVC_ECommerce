using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Abstracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        Task<string> AddOrderAsync(Order Order);
        Task<string> DeleteOrderAsync(Order Order);
        Task<string> UpdateOrderAsync(Order Order);
        IEnumerable<Order> GetActiveOrders();
        IEnumerable<Order> GetPassiveOrders();
        Task<string> DestroyOrderAsync(Order Order);
    }
}
