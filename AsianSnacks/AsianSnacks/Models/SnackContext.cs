using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace AsianSnacks.Models
{
    public class SnackContext : DbContext
    {
        public SnackContext():base("AsianSnacks")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Snack> Snacks { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}