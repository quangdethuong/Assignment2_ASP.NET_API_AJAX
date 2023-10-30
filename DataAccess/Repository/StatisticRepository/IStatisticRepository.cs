using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.StatisticRepository
{
    public interface IStatisticRepository
    {
        List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate);
    }
}
