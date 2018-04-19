using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
public class HomeController : Controller
{
[HttpGet("/")]
public ActionResult Index()
{
  List<Item> allItems = Item.GetAll();
  return View(allItems);
}
}
}


// [HttpPost("/items")]
// public ActionResult Create()
// {
//   Item newItem = new Item(Request.Form["new-item"]);
//   List<Item> allItems = Item.GetAll();
//   return View("Index", allItems);
//
//   {
