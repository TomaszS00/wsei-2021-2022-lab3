using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_1.Controllers
{
    public class ProductsApiController : ControllerBase
    {
        
        public IActionResult Add(ProductModel product)
        {
            return Ok();
        }
    }
}
