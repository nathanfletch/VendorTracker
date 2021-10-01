using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Constructor_HasCorrectType_Vendor()
    {
      //arrange
      Type expectedType = typeof(Vendor);
      //act
      Vendor myVendor = new Vendor("test");
      Type resultType = myVendor.GetType();
      //assert
      Assert.AreEqual(expectedType, resultType);
    }
    [TestMethod]
    public void Constructor_AssignsNameProp_Test()
    {
      //arrange
      string expected = "test";
      //act
      Vendor myVendor = new Vendor("test");
      string result = myVendor.Name;
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Constructor_AssignsId_1()
    {
      //arrange
      int expected = 1;
      //act
      Vendor myVendor = new Vendor("test");
      int result = myVendor.Id;
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVenders_VenderList()
    {
      //Arrange
      string vendorName1 = "test1";
      string vendorName2 = "test2";
      Vendor myVendor1 = new Vendor(vendorName1);
      Vendor myVendor2 = new Vendor(vendorName2);
      List<Vendor> expected = new List<Vendor> { myVendor1, myVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string vendorName1 = "test1";
      string vendorName2 = "test2";
      Vendor myVendor1 = new Vendor(vendorName1);
      Vendor myVendor2 = new Vendor(vendorName2);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(myVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      //Arrange
      Order myOrder = new Order(3,"test", "test-date");
      List<Order> expected = new List<Order> { myOrder };
      Vendor myVendor = new Vendor("asdfjkl");
      myVendor.AddOrder(myOrder);

      //Act
      List<Order> result = myVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void Sort_SortsDescending_2Before1()
    {
      //Arrange
      Vendor myVendor = new Vendor("asdfjkl");
      Order myOrder1 = new Order(1,"test", "test-date");
      Order myOrder2 = new Order(2,"test", "test-date");
      myVendor.AddOrder(myOrder1);
      myVendor.AddOrder(myOrder2);
      List<Order> expected = new List<Order> { myOrder2, myOrder1 };

      //Act
      myVendor.Sort();
      List<Order> result = myVendor.SortedOrders;

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
  }
}