using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;


namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void Constructor_HasCorrectType_Order()
    {
      //arrange
      Type expectedType = typeof(Order);
      //act
      Order myOrder = new Order(2, "test");
      Type resultType = myOrder.GetType();
      //assert
      Assert.AreEqual(expectedType, resultType);
    }
    [TestMethod]
    public void Constructor_AssignsNumDescPriceDateProps_1Test2Oct12021()
    {
      //arrange
      int expectedNum = 1;
      string expectedDesc = "test";
      int expectedPrice = 2;
      string expectedDate = "October 1st, 2021";
      //act
      Order myOrder = new Order(1, "test");
      int resultNum = myOrder.NumItems;
      string resultDesc = myOrder.Description;
      int resultPrice = myOrder.Price;
      string resultDate = myOrder.Date;
      //assert
      Assert.AreEqual(expectedNum, resultNum);
      Assert.AreEqual(expectedDesc, resultDesc);
      Assert.AreEqual(expectedPrice, resultPrice);
      Assert.AreEqual(expectedDate, resultDate);
    }
    [TestMethod]
    public void Constructor_AssignsId_1()
    {
      //arrange
      int expected = 1;
      //act
      Order myOrder = new Order(1, "test");
      int result = myOrder.Id;
      //assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      //Arrange
      string orderName1 = "test1";
      string orderName2 = "test2";
      Order myOrder1 = new Order(2, orderName1);
      Order myOrder2 = new Order(2, orderName2);
      List<Order> expected = new List<Order> { myOrder1, myOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
  }
}