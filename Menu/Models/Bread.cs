using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrders
  {
    public int OrderAmount { get; set; }
    // public int Bill { get; set; }
    
    public BreadOrders(int orderedAmount)
    {
      OrderAmount = orderedAmount;
    }

    public int SumPrice()
    {
      int summedPrice = OrderAmount * 5;
      return summedPrice;
    }
  }
}