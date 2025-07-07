using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_Sting()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor1 = "Betty";
      string vendor2 = "Garry";
      Vendor newVendor1 = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);
      List<Vendor> newVendorList = new List<Vendor> {newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Betty";
      string vendor2 = "Garry";
      Vendor newVendor1 = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderDescription = "12 strawberries";
      Order newOrder = new Order(orderDescription);
      List<Order> newOrderList = new List<Order> { newOrder };
      string vendorName = "Betty";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Order;

      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}