using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
    
  }
}