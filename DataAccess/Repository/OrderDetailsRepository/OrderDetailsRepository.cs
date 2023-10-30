using BusinessObject;
using DataAccess.DAO.OrderDetailsDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.OrderDetailsRepository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public void AddOD(OrderDetail o) => OrderDetailsDAO.Instance.AddOderDetail(o);


        public void DeleteOD(int idO, int idP) => OrderDetailsDAO.Instance.Delete(idO, idP);


        public OrderDetail GetOrderDetail(int idO, int idP) => OrderDetailsDAO.Instance.GetOrderDetail(idO, idP);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailsDAO.Instance.GetOrders();

        public void UpdateOD(OrderDetail o) => OrderDetailsDAO.Instance.Modify(o);

    }
}
