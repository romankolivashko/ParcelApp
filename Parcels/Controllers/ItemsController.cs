using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      // ViewData["Error"] = "Error!"; 
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description, string length, string width, string height, string weight, string price)
    {
      Item myItem = new Item(description, length, width, height, weight, price);
      // Item myLength = new Item(length);
      return RedirectToAction("Index");
    }

  }
}