using System.Collections.Generic;
using System;
using Bakery.Models;
using Bread.Models;

namespace Pastry.Models {

  public class PastryOrder
  {
    public int TotalPastry { get; set; }

    public PastryOrder(int totalPastry)
    {
      TotalPastry = totalPastry;

      // _instances.Add(this);
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
      else 
      {
        orderTotal = 9;
      }
      return orderTotal;
    }
  }
}