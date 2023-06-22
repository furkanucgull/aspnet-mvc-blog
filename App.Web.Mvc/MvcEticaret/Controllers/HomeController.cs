using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using MvcEticaret.ViewComponents;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var productList = new List<ProductItemViewModel>
        {
                 new ProductItemViewModel
            {
                Title = "Watch 1",
                StarCount = 2,
                OldPrice = 99.5m,
                Price = 79.5m,
                ImageUrl = "/images/product1.jpg",
                IsSale = true
            },
                 new ProductItemViewModel
            {
                Title = "Watch 2",
                StarCount = 3,
                OldPrice = 93,
                Price = 65.59m,
                ImageUrl = "/images/product2.jpg",
                IsSale = false
            },
                 new ProductItemViewModel
            {
                Title = "Watch 3",
                StarCount = 4,
                OldPrice = 43,
                Price = 20,
                ImageUrl = "/images/product3.jpg",
                IsSale = true
            },

                 new ProductItemViewModel
            {
                Title = "Watch 4",
                StarCount = 5,
                OldPrice = 90,
                Price = 45,
                ImageUrl = "/images/product4.jpg",
                IsSale = false
            },

                 new ProductItemViewModel
            {
                Title = "Watch 5",
                StarCount = 3,
                OldPrice = 92,
                Price = 86.99m,
                ImageUrl = "/images/product5.jpg",
                IsSale = false
            },
                new ProductItemViewModel
            {
                Title = "Watch 6",
                StarCount = 4,
                OldPrice = 55,
                Price = 38.95m,
                ImageUrl = "/images/product6.jpg",
                IsSale = false
            },
                new ProductItemViewModel
            {
                Title = "Watch 7",
                StarCount = 3,
                OldPrice = 92,
                Price = 75,
                ImageUrl = "/images/product7.1.jpg",
                IsSale = true
            },
                new ProductItemViewModel
            {
                Title = "Watch 8",
                StarCount = 2,
                OldPrice = 49,
                Price = 29.5m,
                ImageUrl = "/images/product8.png",
                IsSale = false
            },
            };

            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}