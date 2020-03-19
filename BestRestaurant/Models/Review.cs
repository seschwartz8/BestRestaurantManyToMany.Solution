using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Name { get; set; }
    public string Date { get; set; }
    public int Rating { get; set; }
    public string Text { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}