using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.OrderRepository
{
    public interface IOrderRepository
    {

        List<Order> GetOrders();
        List<Order> GetOrderByMemberId(string id);

        void DeleteOrder(int idO);

        Order GetOrder(int id);

        void UpdateOrder(Order o);

        void AddOrder(Order order);
        List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate);
        //List<Order> Filter(DateTime startDate, DateTime endDate);

    }
}
