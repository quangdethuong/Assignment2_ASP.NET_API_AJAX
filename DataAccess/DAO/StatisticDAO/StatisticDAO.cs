using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.StatisticDAO
{
    public class StatisticDAO
    {
        private static StatisticDAO instance = null;
        public static readonly object instanceLock = new object();
        public static StatisticDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StatisticDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> Statistical(DateTime startDate, DateTime endDate)
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
