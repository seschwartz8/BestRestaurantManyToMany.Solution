using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BestRestaurant.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Controllers
{
  [Authorize]
  public class ReviewsController : Controller
  {
    private readonly BestRestaurantContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ReviewsController(UserManager<ApplicationUser> userManager, BestRestaurantContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet]
    public ActionResult Create(int id)
    {
      ViewBag.RestaurantId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review, int id)
    {
      review.RestaurantId = id;
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants", id);
    }

    public ActionResult Edit(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
      return View(thisReview);
    }

    [HttpPost]
    public ActionResult Update(Review review)
    {
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Restaurants", new { id = review.RestaurantId });
    }
    // [HttpPost]
    // public ActionResult Update(Restaurant restaurant, int CuisineId)
    // {
    //   if (CuisineId != 0)
    //   {
    //     _db.CuisineRestaurant.Add(new CuisineRestaurant() { RestaurantId = restaurant.RestaurantId, CuisineId = CuisineId });
    //   }
    //   _db.Entry(restaurant).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}