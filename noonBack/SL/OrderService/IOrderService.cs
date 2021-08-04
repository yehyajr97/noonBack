using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.OrderService
{
    interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrder(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
