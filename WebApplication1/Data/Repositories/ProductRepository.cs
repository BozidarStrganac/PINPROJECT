using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> Products => _appDbContext.Products.Include(ps=> ps.ProductSorter);
        public IEnumerable<Product> PrefferedProducts => _appDbContext.Products.Where(pp => pp.IsMostLiked).Include(ps => ps.ProductSorter);

        public Product GetProductByID(int productID) => _appDbContext.Products.FirstOrDefault(p => p.ProductID == productID);
    }
}
