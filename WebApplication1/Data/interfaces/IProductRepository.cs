using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> PrefferedProducts { get; }
        Product GetProductByID(int productID);
    }
}
