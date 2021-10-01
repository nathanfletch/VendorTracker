using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorTracker.Models
{
   public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public bool IsSorted {get; set;}
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public List<Order> SortedOrders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      IsSorted = false;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
      SortedOrders = new List<Order>();

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

    public void Sort()
    {
      SortedOrders = Orders.OrderByDescending(order => order.Price).ToList();
      //using the boolean allows future potential sorting methods as opposed to only by price using (SortedOrders.Count == 0) as a conditional in the .cshtml file 
      IsSorted = true;
    }
    public void UnSort()
    {
      SortedOrders.Clear();
      IsSorted = false;
    }
  }
}

/*
Trello board simulator: 
Extras: 

edit/update:
-test/write method to update 
-make a get link from show page /vendors/{id}/orders/{id}/update
-offer form (route)
-call post submit route
-controller edit route (Update)

delete - delete breaks the find function as currently implemented because it's linked to the index



order items - import and integrate last week's project


Done extras:
build Order show
sort/filter buttons




MVP Done: 

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



*/