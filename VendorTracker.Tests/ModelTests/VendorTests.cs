using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

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
    
  }
}