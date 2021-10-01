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
  }
}