using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id) 
    { 
      //get vendor by id
      Vendor vendorToAddTo = Vendor.Find(id);
      //pass into view
      return View(vendorToAddTo); 
    }
  }
}