using BusinessObject;
using DataAccess.DAO.StatisticDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.StatisticRepository
{
    public class StatisticRepository : IStatisticRepository
    {
        public List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate) => StatisticDAO.Instance.Statistical(startDate, endDate);
    }
}
