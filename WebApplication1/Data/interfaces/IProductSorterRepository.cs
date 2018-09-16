using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IProductSorterRepository
    {
        IEnumerable<ProductSorter> ProductSorters { get; }
    }
}
