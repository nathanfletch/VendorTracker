using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
    
  }
}