using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediafyTaskProducts.Models;
using MediafyTaskProducts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MediafyTaskProducts.Pages
{
    public class ProductDescriptionModel : PageModel
    {
        private readonly ILogger<ProductDescriptionModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public ProductDescriptionModel(ILogger<ProductDescriptionModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }

}
