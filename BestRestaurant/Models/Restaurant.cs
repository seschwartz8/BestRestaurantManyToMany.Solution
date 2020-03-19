using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Cuisines = new HashSet<CuisineRestaurant>();
      this.Reviews = new HashSet<Review>();
    }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<CuisineRestaurant> Cuisines { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}