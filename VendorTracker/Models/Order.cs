using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int NumItems {get; set;}
    public string Description {get; set;}
    //delivery, pickup, online
    public int Price { get; set;}
    //logic to calc price
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};


    public Order(int numCroissants, string description)
    {
      NumItems = numCroissants;
      Description = ""; //description;
      Price = numCroissants * 2;
      Date =  "October 1st, 2021";
      _instances.Add(this); //all categories
      Id = _instances.Count;
    }

    // public static Order Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

    // public static List<Order> GetAll()
    // {
    //   return _instances;
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}