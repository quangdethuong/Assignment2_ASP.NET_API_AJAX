using BusinessObject;
using DataAccess.DAO.OrderDAO;
using DataAccess.DAO.StatisticDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);


        public void DeleteOrder(int idO) => OrderDAO.Instance.Delete(idO);


        public Order GetOrder(int id) => OrderDAO.Instance.GetOrderByID(id);

        public List<Order> GetOrderByMemberId(string id) => OrderDAO.Instance.GetOrderByMemberId(id);


        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public void UpdateOrder(Order o) => OrderDAO.Instance.Modify(o);


        public List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate) => OrderDAO.Filter(startDate, endDate);


    }
}
