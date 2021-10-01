using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int NumItems {get; set;}
    public string Description {get; set;}
    public int Price { get; set;}
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(int numCroissants, string description, string date)
    {
      NumItems = numCroissants;
      Description = description;
      Price = numCroissants * 2;
      Date = date;
      _instances.Add(this); 
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
      
    }
    public void UpdateOrder(int num, string desc, string date)
    {
      NumItems =0; //num;
      Description =""; //desc;
      Price =0; //num * 2;
      Date = "";//date;
    }
  }
}