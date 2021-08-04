using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.OrderService
{
    public class OrderService : IOrderService
    {
        #region Property  
        private IRepository<Order> _repository;
        #endregion

        #region Constructor  
        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Order> GetAllOrders()
        {
            return _repository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return _repository.Get(id);
        }

        public void InsertOrder(Order order)
        {
            _repository.Insert(order);
        }
        public void UpdateOrder(Order order)
        {
            _repository.Update(order);
        }

        public void DeleteOrder(int id)
        {
            Order order = GetOrder(id);
            _repository.Remove(order);
            _repository.SaveChanges();
        }
    }
}
