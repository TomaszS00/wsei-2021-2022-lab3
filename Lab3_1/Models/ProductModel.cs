using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_1.Models
{
    public class ProductModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }
    }
}
