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
    
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId) 
    { 
      //find vendor by id
      Vendor associatedVendor = Vendor.Find(vendorId);
      //find order by id
      Order orderToShow = Order.Find(orderId);

      //make and add to a Dictionary
      Dictionary<object, object> model = new Dictionary<object, object>(2) {
        {"vendor", associatedVendor},
        {"order", orderToShow}
      };

      //pass into view
      return View(model); 
    }
  }
}