using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : IdentityDbContext<ApplicationUser>
  {
    //The property is declared virtual to allow entity to lazy load its contents improving our applications efficiency
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<CuisineRestaurant> CuisineRestaurant { get; set; }

    public BestRestaurantContext(DbContextOptions options) : base(options) { }
  }
}