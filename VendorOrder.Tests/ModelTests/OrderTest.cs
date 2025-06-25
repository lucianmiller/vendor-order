using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "12 Strawberries";

      Order newOrder = new Order(description);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "12 Strawberries";
      Order newOrder = new Order(description);

      string updatedOrder = "4 Potatoes";
      newOrder.Description = updatedOrder;
      string result = newOrder.Description;

      Assert.AreEqual(updatedOrder, newOrder.Description);
    }
  }
}