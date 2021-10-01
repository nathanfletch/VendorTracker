using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
   public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      Vendor goodFailVendor = new Vendor("good fail");
      
      return _instances;
    }
    // public static Vendor Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
    
  }

}

/*
Trello board simulator: 

build logic files w/ tests - just utility/constructors at this point
  Order: title, the description, the price, the date

build out MVC for the required stuff: new order form

// display all info - bootstrap cards

Readme

build out rest of Objects within Objects restful routes

Further: 

edit/delete - delete breaks the find function as currently implemented because it's linked to the index

sort/filter buttons?


order items - import and integrate last week's project



*/