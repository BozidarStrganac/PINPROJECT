using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductSorterRepository _productSorterRepository;
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository, IProductSorterRepository productSorterRepository)
        {
            _productRepository = productRepository;
            _productSorterRepository = productSorterRepository;
        }

        public ViewResult ProductList()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Products = _productRepository.Products;
            viewModel.CurrentProductSorter = "ProductSorter";
            
            return View(viewModel);
        }
    }
}
