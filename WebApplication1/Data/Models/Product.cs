using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsMostLiked { get; set; }
        public bool InStock { get; set; }
        public int ProductSorterID { get; set; }
        public virtual ProductSorter ProductSorter { get; set; }
    }
}
