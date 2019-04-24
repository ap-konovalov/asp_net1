using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData _ProductData;


        public CatalogController(IProductData ProductData)
        {
            _ProductData = ProductData;
        }
        
        public IActionResult Shop(int? SectionId, int? BrandId)
        {
            var products = _ProductData.GetProducts(new ProductFilter
            {
                SectionId = SectionId,
                BrandId = BrandId
            });

            var catalog_model = new CatalogViewModel
            {
                BrandId = BrandId,
                SectionId = SectionId,
                Products = products.Select( product => new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Order = product.Order,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl
                })

            };
            
            return View(catalog_model);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _ProductData.GetProductById(id);

            if (product is null)
            {
                return NotFound();
            }

            return View(new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Order = product.Order,
                ImageUrl = product.ImageUrl,
                Brand = product.Brand?.Name
            });
        }
    }
}