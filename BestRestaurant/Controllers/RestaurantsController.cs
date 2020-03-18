using System.Collections.Generic;
using System.Linq;
using BestRestaurant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantContext _db;

    public RestaurantsController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Cuisines = (List<Cuisine>) _db.Cuisines.ToList();
      List<Restaurant> model = _db.Restaurants.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant, int CuisineId)
    {
      _db.Restaurants.Add(restaurant);
      if (CuisineId != 0)
      {
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { CuisineId = CuisineId, RestaurantId = restaurant.RestaurantId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisRestaurant = _db.Restaurants
        .Include(restaurant => restaurant.Cuisines)
        .ThenInclude(join => join.Cuisine)
        .FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
      // Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      // return View(thisRestaurant);
    }

    public ActionResult Edit(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View(thisRestaurant);
    }

    [HttpPost]
    public ActionResult Update(Restaurant restaurant, int CuisineId)
    {
      if (CuisineId != 0)
      {
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { RestaurantId = restaurant.RestaurantId, CuisineId = CuisineId });
      }
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
      // _db.Entry(restaurant).State = EntityState.Modified;
      // _db.SaveChanges();
      // return RedirectToAction("Index");
    }

    public ActionResult AddCuisine(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View(thisRestaurant);
    }

    [HttpPost]
    public ActionResult AddCuisine(Restaurant restaurant, int CuisineId)
    {
      if (CuisineId != 0)
      {
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { RestaurantId = restaurant.RestaurantId, CuisineId = CuisineId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisRestaurant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // [HttpPost]
    // public ActionResult DeleteCuisine(int joinId)
    // {
    //   var joinEntry = _db.CuisineRestaurant.FirstOrDefault(entry => entry.CuisineRestaurantId == joinId);
    //   _db.CuisineRestaurant.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}