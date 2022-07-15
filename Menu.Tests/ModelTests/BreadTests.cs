using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;

namespace Bread.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrdersConstructor_CreatesInstanceOfItem_BreadOrders()
    {
      BreadOrders newBill = new BreadOrders(5);
      Assert.AreEqual(typeof(BreadOrders), newBill.GetType());
    }

    [TestMethod]
    public void GetOrderAmount_ReturnsNumberOfLoaves_int()
    {
      int testOrder = 3;
      BreadOrders newBill = new BreadOrders(testOrder);
      int result = newBill.OrderAmount;
      Assert.AreEqual(testOrder, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      int description = 5;
      BreadOrders newOrder = new BreadOrders(description);
      int updateDescription = 20;
      newOrder.OrderAmount = updateDescription;
      int result = newOrder.OrderAmount;
      Assert.AreEqual(updateDescription, result);
    }
  }
}