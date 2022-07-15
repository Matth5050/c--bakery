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
    public void GetOrderAmount_ReturnsNumberOfLoaves_3()
    {
      int testOrder = 3;
      BreadOrders newBill = new BreadOrders(testOrder);
      int result = newBill.OrderAmount;
      Assert.AreEqual(testOrder, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_20()
    {
      int description = 5;
      BreadOrders newOrder = new BreadOrders(description);
      int updateDescription = 20;
      newOrder.OrderAmount = updateDescription;
      int result = newOrder.OrderAmount;
      Assert.AreEqual(updateDescription, result);
    }

    [TestMethod]
    public void SumPrice_SumsTotalPrice_15()
    {
      BreadOrders newOrder = new BreadOrders(3);
      Assert.AreEqual(15, newOrder.SumPrice());
    }

    [TestMethod]
    public void SumPrice_SetsBill_10()
    {
      BreadOrders newOrder = new BreadOrders(2);
      newOrder.SumPrice();
      Assert.AreEqual(10, newOrder.Bill);
    }

    [TestMethod]
    public void SumPrice_SetsFinalPrice_10()
    {
      BreadOrders newOrder = new BreadOrders(2);
      newOrder.SumPrice();
      Assert.AreEqual(10, newOrder.FinalPrice);
    }

    [TestMethod]
    public void CheckDiscount_ChecksIfDivisbileByThree_10()
    {
      BreadOrders newOrder = new BreadOrders(3);
      newOrder.SumPrice();
      newOrder.CheckDiscount();
      Assert.AreEqual(10, newOrder.FinalPrice);
    }
  }
}


