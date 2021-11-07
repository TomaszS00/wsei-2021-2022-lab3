using Lab3_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
            };
            return View(viewModel);
        }


    }
}
