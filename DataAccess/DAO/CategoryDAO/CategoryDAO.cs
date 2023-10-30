using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.CategoryDAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        public static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Category> GetListCategories()
        {
            var cates = new List<Category>();
            try
            {
                using var context = new MyDbContext();
                cates = context.Categories.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cates;
        }

    }
}
