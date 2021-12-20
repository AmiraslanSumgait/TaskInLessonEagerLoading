using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTaskInLesson.Models;

namespace WpfTaskInLesson.DataAccess.Context
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5EGU4LU;Initial Catalog=MyProducts;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
    }
}
