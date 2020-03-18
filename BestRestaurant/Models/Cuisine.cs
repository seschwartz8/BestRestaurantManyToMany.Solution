using System.Collections.Generic;

namespace BestRestaurant.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurants = new HashSet<CuisineRestaurant>();
        }

        public int CuisineId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<CuisineRestaurant> Restaurants { get; set; }
    }
}