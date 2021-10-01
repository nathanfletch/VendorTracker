using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

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
  }
}