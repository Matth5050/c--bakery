using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;

namespace Pastry.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrdersConstructor_CreatesInstanceOfItem_PastryOrders()
    {
      PastryOrders newOrder = new PastryOrders(5);
      Assert.AreEqual(typeof(PastryOrders), newOrder.GetType());
    }

    [TestMethod]
    public void SetOrderAmount_SetOrderAmount_int()
    {
      int orderedAmount = 5;
      PastryOrders newOrder = new PastryOrders(orderedAmount);
      int updateOrdredAmount = 20;
      newOrder.OrderAmount = updateOrdredAmount;
      int result = newOrder.OrderAmount;
      Assert.AreEqual(updateOrdredAmount, result);
    }

    [TestMethod]
    public void SumPrice_SumsTotalPrice_int()
    {
      PastryOrders newOrder = new PastryOrders(1);
      Assert.AreEqual(2, newOrder.SumPrice());
    }

    [TestMethod]
    public void SumPrice_SetsBill_int()
    {
      PastryOrders newOrder = new PastryOrders(2);
      newOrder.SumPrice();
      Assert.AreEqual(4, newOrder.Bill);
    }

    // [TestMethod]
    // public void SumPrice_SetsFinalPrice_int()
    // {
    //   BreadOrders newOrder = new BreadOrders(2);
    //   newOrder.SumPrice();
    //   Assert.AreEqual(10, newOrder.FinalPrice);
    // }

    // [TestMethod]
    // public void CheckDiscount_ChecksIfDivisbileByThree_int()
    // {
    //   BreadOrders newOrder = new BreadOrders(3);
    //   newOrder.SumPrice();
    //   newOrder.CheckDiscount();
    //   Assert.AreEqual(10, newOrder.FinalPrice);
    // }
  }
}