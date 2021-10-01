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
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor); 
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, int number, string description, string date)
    {
      //get the vendor, create the order, add the order, pass vendor to Show

      Vendor vendorToAddTo = Vendor.Find(vendorId);

      Order newOrder = new Order(number, description, date);

      vendorToAddTo.AddOrder(newOrder);
      vendorToAddTo.UnSort();

      return View("Show", vendorToAddTo);
    }

    [HttpGet("/vendors/{vendorId}/sorted")]
    public ActionResult Sorted(int vendorId)
    {
      Vendor vendorToSort = Vendor.Find(vendorId);
      vendorToSort.Sort();

      return View("Show", vendorToSort);
    }
    
    [HttpGet("/vendors/{vendorId}/unsorted")]
    public ActionResult UnSorted(int vendorId)
    {
      Vendor vendorToUnSort = Vendor.Find(vendorId);
      vendorToUnSort.UnSort();

      return View("Show", vendorToUnSort);
    }
  }
}