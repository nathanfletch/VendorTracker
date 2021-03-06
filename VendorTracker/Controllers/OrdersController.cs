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
    
    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId, int number, string description, string date) 
    { 
      //find vendor by id
      Vendor associatedVendor = Vendor.Find(vendorId);
      //find order by id
      Order orderToEdit = Order.Find(orderId);

      //make and add to a Dictionary
      Dictionary<object, object> model = new Dictionary<object, object>(2) {
        {"vendor", associatedVendor},
        {"order", orderToEdit}
      };

      //pass into view for order details
      return View(model); 
    }
    
    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Update(int vendorId, int orderId, int number, string description, string date) 
    { 
      //find vendor by id
      Vendor associatedVendor = Vendor.Find(vendorId);
      //find order by id
      Order orderToUpdate = Order.Find(orderId);
      //update
      orderToUpdate.UpdateOrder(number, description, date);
      //make and add to a Dictionary
      Dictionary<object, object> model = new Dictionary<object, object>(2) {
        {"vendor", associatedVendor},
        {"order", orderToUpdate}
      };

      //pass into view
      return View("Show", model); 
    }
  }
}