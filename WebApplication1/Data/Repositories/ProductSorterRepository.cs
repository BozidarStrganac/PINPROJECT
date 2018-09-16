using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
    public class ProductSorterRepository : IProductSorterRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductSorterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<ProductSorter> ProductSorters => _appDbContext.ProductSorters;
    }
}
