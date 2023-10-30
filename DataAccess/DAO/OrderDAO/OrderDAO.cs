using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.OrderDAO
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        public static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> GetOrders()
        {
            var ods = new List<Order>();
            try
            {
                using var context = new MyDbContext();
                ods = context.Orders.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ods;
        }
        public Order GetOrderByID(int id)
        {
            Order or = null;
            try
            {
                using var context = new MyDbContext();
                or = context.Orders.SingleOrDefault(m => m.OrderId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return or;
        }

        public List<Order> GetOrderByMemberId(string id)
        {
            var or = new List<Order>();
            try
            {
                using var context = new MyDbContext();
                or = context.Orders.Where(m => m.MemberId == id).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return or;
        }

        public void AddOrder(Order order)
        {
            try
            {
                Order _o = GetOrderByID(order.OrderId);
                if (_o == null)
                {
                    using var context = new MyDbContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else throw new Exception("Order is exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Modify(Order o)
        {
            try
            {
                Order _o = GetOrderByID(o.OrderId);
                if (_o != null)
                {
                    using var context = new MyDbContext();
                    context.Orders.Update(o);
                    context.SaveChanges();
                }
                else throw new Exception("Order is not exist!");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                Order _o = GetOrderByID(id);
                if (_o != null)
                {
                    using var context = new MyDbContext();
                    context.Orders.Remove(_o);
                    context.SaveChanges();
                }
                else throw new Exception("Order is not exist!");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Order> Filter(DateTime startDate, DateTime EndDate)
        {
            var orders = new List<Order>();
            var filter = new List<Order>();
            try
            {
                using (var db = new MyDbContext())
                {
                    orders = db.Orders.ToList();
                    for (int i = 0; i < orders.Count; i++)
                    {
                        if (orders[i].OrderDate >= startDate && orders[i].OrderDate <= EndDate)
                        {
                            filter.Add(orders[i]);
                        }
                    }
                    filter = filter.OrderByDescending(f => f.OrderDate).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return filter;
        }


        public List<Order> StatisticOrder(DateTime startDate, DateTime endDate)
        {
            var ods = new List<Order>();
            try
            {
                using var context = new MyDbContext();

                ods = context.Orders
                    .Where(order => order.OrderDate >= startDate && order.OrderDate <= endDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ods;
        }
    }

}

