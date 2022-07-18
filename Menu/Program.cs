using System;
using System.Collections.Generic;
using System.Timers;
using Bread.Models;
using Pastry.Models;


namespace Program.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to the C# Bakery!!");
      Console.WriteLine("Today we are offering Bread and Pastries:");
      Console.WriteLine("------------------------------------------");
      Console.WriteLine("Bread: 1 loaf for 5$ or every 3rd loaf free");
      Console.WriteLine("Pastry: 1 for 2$, 1$ off orders of more than 1, 2$ off orders of more than 6");
      Console.WriteLine("Would you like bread or pastries? (bread/pastries)");
      string orderResponse = Console.ReadLine();
      string lowerOrderResponse = orderResponse.ToLower();
      
      if (lowerOrderResponse == "bread") 
      {
        Console.WriteLine("How many loaves do you want?");
        string loafAmount = Console.ReadLine();
        int loafAmountNum = int.Parse(loafAmount);
        BreadOrders userOrder = new BreadOrders(loafAmountNum);
        userOrder.SumPrice();
        userOrder.CheckDiscount();
        Console.WriteLine("Your order of " + userOrder.OrderAmount + " loaf(loaves)" + " will be " + userOrder.FinalPrice + "$");
      }
      else if (lowerOrderResponse == "pastries")
      {
        Console.WriteLine("How many pastries do you want?");
        string pastryAmount = Console.ReadLine();
        int pastryAmountNum = int.Parse(pastryAmount);
        PastryOrders userOrderPastry = new PastryOrders(pastryAmountNum);
        userOrderPastry.SumPastryPrice();
        userOrderPastry.CheckPastryDiscount();
        Console.WriteLine("Your order of " + userOrderPastry.OrderAmount + " pastries" + " will be " + userOrderPastry.FinalPrice + "$");
      }
      else
      {
        Console.WriteLine("Please enter either bread or pastries");
        Main();
      }
    }
  }
}