using DefectiveGoods.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DefectiveGoods.Core
{
    public class DefectiveGoodsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DefectiveGoodsDb;Trusted_Connection=True;");
        }

    }
}
