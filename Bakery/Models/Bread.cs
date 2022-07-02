using System.Collections.Generic;
using System;
using Bakery.Models;
using Pastry.Models;
using Bakery;

namespace Bread.Models {

  public class BreadOrder
  {
    public int TotalLoaves { get; set; }

    public BreadOrder(int totalLoaves)
    {
      TotalLoaves = totalLoaves;
    }
    
    public int FindBreadOrderTotal()
    {
      int orderTotal = 0;
      int total = TotalLoaves;
      if (total <= 3)
      {
        if (total == 1) 
        {
          orderTotal = 5;
        }
        else if (total == 2 || total == 3)  
        {
          orderTotal = 10;
        }
      }
      else 
      {
        orderTotal = ((total / 3) * 2 + total % 3) * 5;
      }
      return orderTotal;
    }
  }
}