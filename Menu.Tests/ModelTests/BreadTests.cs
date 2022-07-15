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
    public void BreadInvoiceConstructor_CreatesInstanceOfItem_BreadInvoice()
    {
      BreadOrders newBill = new BreadOrders(5);
      Assert.AreEqual(typeof(BreadOrders), newBill.GetType());
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   // Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   // Act
    //   string result = newItem.Description;
    //   // Assert
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   // Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   // Act
    //   string updateDescription = "Do the dishes";
    //   newItem.Description = updateDescription;
    //   string result = newItem.Description;

    //   // Assert
    //   Assert.AreEqual(updateDescription, result);
    // }

  }
}