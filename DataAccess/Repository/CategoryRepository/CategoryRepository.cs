using BusinessObject;
using DataAccess.DAO.CategoryDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetAllCategories() => CategoryDAO.Instance.GetListCategories();
    }
}
