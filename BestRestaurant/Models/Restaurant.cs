using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Cuisines = new HashSet<CuisineRestaurant>();
    }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<CuisineRestaurant> Cuisines { get; set; }
  }
}