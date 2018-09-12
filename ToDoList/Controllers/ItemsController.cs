using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      // List<Item> allItems = new List<Item> {};
      // return View(allItems);

      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create()
    {//]
      Item newItem = new Item(Request.Form["new-item"],Request.Form["new-name"] );
      //newItem.Save();
      List<Item> allItems = Item.GetAll();
      return View("Index", allItems);

    }

    [HttpPost("/items/delete")]
      public ActionResult DeleteAll()
      {
          Item.ClearAll();
          return View();
      }

      [HttpGet("/items/{id}")]
       public ActionResult Details(int id)
       {
           Item item = Item.Find(id);
           return View(item);
       }




  }
}
