using Microsoft.EntityFrameworkCore;
using ASPWEBAPI.Models;

namespace ASPWEBAPI 
{
    public class ShopContext : DbContext
    {
       public DbSet<Product> Products { get; set; } = null!;
    }

  
}