using System;
using GroceryList.Models;
using Microsoft.EntityFrameworkCore;


namespace GroceryList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
