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
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    
    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }
  }
}

/*
Trello board simulator: 




Done: 

build logic files w/ tests - just utility/constructors at this point
  Order: title, the description, the price, the date

build out MVC for the required stuff: 
done: Splash

Vendor: 
done: index
goto form
create
show

Order:
goto form
create

// styling

Readme

build Order show


Further: 

edit/delete - delete breaks the find function as currently implemented because it's linked to the index

sort/filter buttons?


order items - import and integrate last week's project


D

*/