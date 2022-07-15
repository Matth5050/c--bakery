using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class PastryOrders
  {
    public int OrderAmount { get; set; }
    public int Bill { get; set; }
    public int FinalPrice { get; set; }
    
    public PastryOrders(int orderedAmount)
    {
      OrderAmount = orderedAmount;
      Bill = 0;
      FinalPrice = 0;
    }

    public int SumPrice()
    {
      int summedPrice = OrderAmount * 2;
      Bill = summedPrice;
      FinalPrice = summedPrice;
      return summedPrice;
    }

    public void CheckDiscount()
    {
      if (OrderAmount == 1) 
      {
        FinalPrice = 2;
      }
      else if (OrderAmount > 1 && OrderAmount <= 5)
      {
        FinalPrice = (Bill - 1);
      }
      else if (OrderAmount > 5)
      {
        FinalPrice = (Bill - 2);
      }
      else
      {
        FinalPrice = FinalPrice;
      }
    }
  }
}