using Lab3_1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_1.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppDbContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}
