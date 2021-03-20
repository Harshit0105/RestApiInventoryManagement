using Microsoft.EntityFrameworkCore;
using RestApiInventoryManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInventoryManagement.Data
{
    public class InventoryAppContext : DbContext
    {
        public InventoryAppContext(DbContextOptions<InventoryAppContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
