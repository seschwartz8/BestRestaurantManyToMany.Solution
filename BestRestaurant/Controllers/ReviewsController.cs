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

    // public async Task<ActionResult> Index()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   ViewBag.Cuisines = (List<Cuisine>) _db.Cuisines.ToList();

    //   var userRestaurants = _db.Restaurants.Where(entry => entry.User.Id == currentUser.Id);
    //   return View(userRestaurants);
    // }

    [HttpGet]
    public ActionResult Create(int id)
    {
      ViewBag.RestaurantId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review, int id)
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // restaurant.User = currentUser;
      review.RestaurantId = id;
      _db.Reviews.Add(review);
      // if (CuisineId != 0)
      // {
      //   _db.CuisineRestaurant.Add(new CuisineRestaurant() { CuisineId = CuisineId, RestaurantId = restaurant.RestaurantId });
      // }
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants", id);
    }

    public ActionResult Details(int id)
    {
      Review thisReview = _db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
      return View(thisReview);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
    //   ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
    //   return View(thisRestaurant);
    // }

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

    // public ActionResult AddCuisine(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
    //   ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
    //   return View(thisRestaurant);
    // }

    // [HttpPost]
    // public ActionResult AddCuisine(Restaurant restaurant, int CuisineId)
    // {
    //   if (CuisineId != 0)
    //   {
    //     _db.CuisineRestaurant.Add(new CuisineRestaurant() { RestaurantId = restaurant.RestaurantId, CuisineId = CuisineId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
    //   return View(thisRestaurant);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
    //   _db.Restaurants.Remove(thisRestaurant);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}