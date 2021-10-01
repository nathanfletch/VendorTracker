using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() { 
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors); 
    }

    [HttpGet("/vendors/new")]
    public ActionResult New() { 
      return View(); 
    }
    
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName) { 
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index"); 
    }
    
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id) { 
      Console.WriteLine($"Id: {id}");
      
      //need vendor object (find) list
      Vendor selectedVendor = Vendor.Find(id);
      Console.WriteLine($"Vendor name: {selectedVendor.Name}");
      return View(selectedVendor); 
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, int number, string description)
    {
      Console.WriteLine($"In Create order controller route");
      //get the vendor, create the order, add the order, pass vendor to Show

      Vendor vendorToAddTo = Vendor.Find(vendorId);

      Order newOrder = new Order(number, description);
      // newOrder.Date = date;

      vendorToAddTo.AddOrder(newOrder);

      Console.WriteLine($"Order num of items: {newOrder.NumItems}");
      Console.WriteLine($"Order desc: {newOrder.Description}");
      Console.WriteLine($"Order price: {newOrder.Price}");
      Console.WriteLine($"Order date: {newOrder.Date}");
      
      return View("Show", vendorToAddTo);
    }
  }
}