using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Concretes
{
    public class OrderService : IOrderService
    {
        private readonly IBaseService<Order> _orderRepository;

        public OrderService(IBaseService<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<string> AddOrderAsync(Order Order)
        {
            return await _orderRepository.Add(Order);
        }

        public async Task<string> DeleteOrderAsync(Order Order)
        {
            return await _orderRepository.Delete(Order);
        }

        public async Task<string> DestroyOrderAsync(Order Order)
        {
            return await _orderRepository.DestroyData(Order);
        }

        public IEnumerable<Order> GetActiveOrders()
        {
            return _orderRepository.GetActives();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public IEnumerable<Order> GetPassiveOrders()
        {
            return _orderRepository.GetPassives();
        }

        public async Task<string> UpdateOrderAsync(Order Order)
        {
            return await _orderRepository.Update(Order);
        }
    }
}
