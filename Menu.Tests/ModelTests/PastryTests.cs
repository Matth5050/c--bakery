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

    // [TestMethod]
    // public void GetOrderAmount_ReturnsNumberOfLoaves_int()
    // {
    //   int testOrder = 3;
    //   BreadOrders newBill = new BreadOrders(testOrder);
    //   int result = newBill.OrderAmount;
    //   Assert.AreEqual(testOrder, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_int()
    // {
    //   int description = 5;
    //   BreadOrders newOrder = new BreadOrders(description);
    //   int updateDescription = 20;
    //   newOrder.OrderAmount = updateDescription;
    //   int result = newOrder.OrderAmount;
    //   Assert.AreEqual(updateDescription, result);
    // }

    // [TestMethod]
    // public void SumPrice_SumsTotalPrice_int()
    // {
    //   BreadOrders newOrder = new BreadOrders(3);
    //   Assert.AreEqual(15, newOrder.SumPrice());
    // }

    // [TestMethod]
    // public void SumPrice_SetsBill_int()
    // {
    //   BreadOrders newOrder = new BreadOrders(2);
    //   newOrder.SumPrice();
    //   Assert.AreEqual(10, newOrder.Bill);
    // }

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