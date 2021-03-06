using System.Collections.Generic;
using System;
using Bread.Models;
using Bakery;

namespace Pastry.Models 
{
  public class PastryOrder
  {
    public int TotalPastry { get; set; }

    public PastryOrder(int totalPastry)
    {
      TotalPastry = totalPastry;
    }

    public int FindPastryOrderTotal()
    {
      int orderTotal = 0;
      int total = TotalPastry;
      if (total == 1 || total == 2) 
      {
        orderTotal = total * 2;
      } 
      else if (total == 3)
      {
        orderTotal = 5;
      }
      else if (total == 4)
      {
        orderTotal = 7;
      }
      else if (total == 5)
      {
        orderTotal = 9;
      }
      else 
      {
        orderTotal = 10;
      }
      return orderTotal;
    }
  }
}