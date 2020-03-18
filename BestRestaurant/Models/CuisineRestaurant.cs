using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class CuisineRestaurant
  {
    public int CuisineRestaurantId { get; set; }
    public int CuisineId { get; set; }
    public int RestaurantId { get; set; }

    public Cuisine Cuisine { get; set; }
    public Restaurant Restaurant { get; set; }
  }
}