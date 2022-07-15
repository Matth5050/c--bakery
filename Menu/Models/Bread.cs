using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrders
  {
    public int OrderAmount { get; set; }
    public int Bill { get; set; }
    public int FinalPrice { get; set; }
    
    public BreadOrders(int orderedAmount)
    {
      OrderAmount = orderedAmount;
      Bill = 0;
      FinalPrice = 0;
    }

    public int SumPrice()
    {
      int summedPrice = OrderAmount * 5;
      Bill = summedPrice;
      FinalPrice = summedPrice;
      return summedPrice;
    }

    public void CheckDiscount()
    {
      if (Bill % 3 == 0) 
      {
        FinalPrice = (Bill / 3) * 2;
      }
      else
      {
        FinalPrice = FinalPrice;
      }
    }
  }
}