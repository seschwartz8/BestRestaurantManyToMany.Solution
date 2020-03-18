using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BestRestaurant.Models
{
  public class BestRestaurantContextContextFactory : IDesignTimeDbContextFactory<BestRestaurantContext>
  {

    BestRestaurantContext IDesignTimeDbContextFactory<BestRestaurantContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<BestRestaurantContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BestRestaurantContext(builder.Options);
    }
  }
}