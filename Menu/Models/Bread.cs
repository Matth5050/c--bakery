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
      FinalPrice = 0;
      return summedPrice;
    }

    public void CheckDiscount()
    {
      for (int index = 0; index <= OrderAmount; index++) 
      {
        if (index % 3 == 0) 
        {
          FinalPrice += 0;
        }
        else
        {
          FinalPrice += 5;
        }
      }
    }
  }
}

