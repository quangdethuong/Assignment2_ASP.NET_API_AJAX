using BusinessObject;
using DataAccess.DAO.CategoryDAO;
using DataAccess.DAO.ProductDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);


        public List<Category> GetCategories() => CategoryDAO.Instance.GetListCategories();


        public Product GetProductById(int id) => ProductDAO.FindProductById(id);


        public List<Product> GetProducts(string search) => ProductDAO.GetProducts(search);


        public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
        //public List<Product> SearchProduct(string search) => ProductDAO.SearchProduct(search);



        public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);
    }
}
